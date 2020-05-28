using AutoMapper;
using Bilten.Model;
using Bilten.Model.Requests;
using Bilten.Model.Requests.DogadjajDetalji;
using Bilten.Model.Requests.DogadjajiMjere;
using Bilten.Model.Requests.DogadjajSlike;
using Bilten.Model.Requests.DogadjajVideo;
using Bilten.Model.Requests.Kategorije;
using Bilten.Model.Requests.Korisnici;
using Bilten.Model.Requests.Mjere;
using Bilten.Model.Requests.Mugshot;
using Bilten.Model.Requests.OrganizacionaJedinica;
using Bilten.Model.Requests.Osoba;
using Bilten.Model.Requests.OsobeDogadjajDetalji;
using Bilten.Model.Requests.OsobeMugshot;
using Bilten.Model.Requests.PodorganizacionaJedinica;
using Bilten.Model.Requests.Slike;
using Bilten.Model.Requests.Video;
using Bilten.Model.Requests.Vozila;
using Bilten.Model.Requests.VozilaDogadjajDetalji;
using Bilten.Model.Requests.Vrste;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiltenWebAPI.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Kategorije, Bilten.Model.Kategorije>().ReverseMap();
            CreateMap<Database.Kategorije, KategorijeUpsertRequest>().ReverseMap();

            CreateMap<Database.Vrste, Bilten.Model.Vrste>().ReverseMap();
            CreateMap<Database.Vrste, VrsteUpsertRequest>().ReverseMap();

            CreateMap<Database.OrganizacionaJedinica, Bilten.Model.OrganizacionaJedinica>().ReverseMap();
            CreateMap<Database.OrganizacionaJedinica, OrganizacionaJedinicaUpsertRequest>().ReverseMap();

            CreateMap<Database.PodorganizacionaJedinica, Bilten.Model.PodorganizacionaJedinica>().ReverseMap();
            CreateMap<Database.PodorganizacionaJedinica, PodorganizacionaJedinicaUpsertRequest>().ReverseMap();

            CreateMap<Database.Mjere, Bilten.Model.Mjere>().ReverseMap();
            CreateMap<Database.Mjere, MjereUpsertRequest>().ReverseMap();

            CreateMap<Database.Dogadjaj, Bilten.Model.Dogadjaj>().ReverseMap();
            CreateMap<Database.Dogadjaj, DogadjajUpsertRequest>().ReverseMap();

            CreateMap<Database.Osoba, Bilten.Model.Osoba>().ReverseMap();
            CreateMap<Database.Osoba, OsobaUpsertRequest>().ReverseMap();

            CreateMap<Database.Vozila, Bilten.Model.Vozila>().ReverseMap();
            CreateMap<Database.Vozila, VozilaUpsertRequest>().ReverseMap();

            CreateMap<Database.DogadjajMjere, Bilten.Model.DogadjajMjere>().ReverseMap();
            CreateMap<Database.DogadjajMjere, DogadjajiMjereUpsertRequest>().ReverseMap();

            CreateMap<Database.DogadjajDetalji, Bilten.Model.DogadjajDetalji>().ReverseMap();
            CreateMap<Database.DogadjajDetalji, DogadjajDetaljiUpsertRequest>().ReverseMap();
            
            CreateMap<Database.VozilaDogadjajDetalji, Bilten.Model.VozilaDogadjajDetalji>().ReverseMap();
            CreateMap<Database.VozilaDogadjajDetalji, VozilaDogadjajDetaljiUpsertRequest>().ReverseMap();

            CreateMap<Database.OsobeDogadjajDetalji, Bilten.Model.OsobeDogadjajDetalji>().ReverseMap();
            CreateMap<Database.OsobeDogadjajDetalji, OsobeDogadjajDetaljiUpsertRequest>().ReverseMap();

            CreateMap<Database.Slike, Bilten.Model.Slike>().ReverseMap();
            CreateMap<Database.Slike, SlikeUpsertRequest>().ReverseMap();

            CreateMap<Database.DogadjajSlike, Bilten.Model.DogadjajSlike>().ReverseMap();
            CreateMap<Database.DogadjajSlike, DogadjajSlikeUpsertRequest>().ReverseMap();

            CreateMap<Database.Korisnici, Bilten.Model.Korisnici>().ReverseMap();
            CreateMap<Database.Korisnici, KorisniciUpsertRequest>().ReverseMap();

            CreateMap<Database.Video, Bilten.Model.Video>().ReverseMap();
            CreateMap<Database.Video, VideoUpsertRequest>().ReverseMap();

            CreateMap<Database.DogadjajVideo, Bilten.Model.DogadjajVideo>().ReverseMap();
            CreateMap<Database.DogadjajVideo, DogadjajVideoUpsertRequest>().ReverseMap();

            CreateMap<Database.Mugshot, Bilten.Model.Mugshot>().ReverseMap();
            CreateMap<Database.Mugshot, MugshotUpsertRequest>().ReverseMap();

            CreateMap<Database.OsobeMugshot, Bilten.Model.OsobeMugshot>().ReverseMap();
            CreateMap<Database.OsobeMugshot, OsobeMugshotUpsertRequest>().ReverseMap();

            CreateMap<Database.VrstaKorisnika, Bilten.Model.VrstaKorisnika>().ReverseMap();

            //CreateMap<Database.Kategorije, Bilten.Model.Mjere>().ForMember(x => x.NazivKategorije, m => m.MapFrom(y => y.Naziv));

            //CreateMap<Database.Mjere, Bilten.Model.Mjere>().ForMember(dest => dest.NazivKategorije, opt => opt.MapFrom(src => src.Kategorije.Naziv));

            //CreateMap<Bilten.Model.Vrste, Database.Vrste>();
            //CreateMap<Database.Korisnici, Model.Requests.KorisniciInsertRequest>().ReverseMap();
        }
    }
}
