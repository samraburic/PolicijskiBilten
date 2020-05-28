using AutoMapper;
using Bilten.Model.Requests.Korisnici;
using BiltenWebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BiltenWebAPI.Services
{
    //public class KorisniciService : BaseCRUDService<Bilten.Model.Korisnici, object, Database.Korisnici, KorisniciUpsertRequest, KorisniciUpsertRequest>
    public class KorisniciService : IKorisniciService
    {
        private readonly RS2_BiltenContext _context;
        private readonly IMapper _mapper;
        public KorisniciService(RS2_BiltenContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Bilten.Model.Korisnici Authenticiraj(string username, string pass)
        {
            var user = _context.Korisnici.Include("VrstaKorisnika").FirstOrDefault(x => x.KorisnickoIme == username);

            if (user != null)
            {
                var hashedPass = GenerateHash(user.LozinkaSalt, pass);

                if (hashedPass == user.LozinkaHash)
                {
                    return _mapper.Map<Bilten.Model.Korisnici>(user);
                }
            }

            return null;
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public List<Bilten.Model.Korisnici> Get(KorisniciSearchRequest request)
        {
            var query = _context.Korisnici.AsQueryable();

            query = query.Include(x => x.VrstaKorisnika);

            if (!string.IsNullOrWhiteSpace(request?.Username))
            {
                query = query.Where(x => x.KorisnickoIme.StartsWith(request.Username));
            }

            if(!string.IsNullOrWhiteSpace(request?.VrstaKorisnika) && request.VrstaKorisnika == "Kontrolor")
            {
                query = query.Where(x => x.VrstaKorisnika.Naziv == request.VrstaKorisnika);
            }

            var list = query.ToList();

            return _mapper.Map<List<Bilten.Model.Korisnici>>(list);
        }

        public Bilten.Model.Korisnici GetById(int id)
        {
            var entity = _context.Korisnici.Find(id);

            return _mapper.Map<Bilten.Model.Korisnici>(entity);
        }

        public Bilten.Model.Korisnici Insert(KorisniciUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Korisnici>(request);

            if (request.Password != request.PasswordPotvrda)
            {
                throw new Exception("Passwordi se ne slažu");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            _context.Korisnici.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Bilten.Model.Korisnici>(entity);
        }

        public Bilten.Model.Korisnici Update(int id, KorisniciUpsertRequest request)
        {
            var entity = _context.Korisnici.Find(id);
            _context.Korisnici.Attach(entity);
            _context.Korisnici.Update(entity);

            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordPotvrda)
                {
                    throw new Exception("Passwordi se ne slažu");
                }

                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            }

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Bilten.Model.Korisnici>(entity);
        }
    }
}
