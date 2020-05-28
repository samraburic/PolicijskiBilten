using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BiltenWebAPI.Database
{
    public partial class RS2_BiltenContext : DbContext
    {
        public RS2_BiltenContext()
        {
        }

        public RS2_BiltenContext(DbContextOptions<RS2_BiltenContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dogadjaj> Dogadjaj { get; set; }
        public virtual DbSet<DogadjajDetalji> DogadjajDetalji { get; set; }
        public virtual DbSet<DogadjajMjere> DogadjajMjere { get; set; }
        public virtual DbSet<DogadjajSlike> DogadjajSlike { get; set; }
        public virtual DbSet<DogadjajVideo> DogadjajVideo { get; set; }
        public virtual DbSet<Kategorije> Kategorije { get; set; }
        public virtual DbSet<Korisnici> Korisnici { get; set; }
        public virtual DbSet<Mjere> Mjere { get; set; }
        public virtual DbSet<Mugshot> Mugshot { get; set; }
        public virtual DbSet<OrganizacionaJedinica> OrganizacionaJedinica { get; set; }
        public virtual DbSet<Osoba> Osoba { get; set; }
        public virtual DbSet<OsobeDogadjajDetalji> OsobeDogadjajDetalji { get; set; }
        public virtual DbSet<OsobeMugshot> OsobeMugshot { get; set; }
        public virtual DbSet<PodorganizacionaJedinica> PodorganizacionaJedinica { get; set; }
        public virtual DbSet<Slike> Slike { get; set; }
        public virtual DbSet<Video> Video { get; set; }
        public virtual DbSet<Vozila> Vozila { get; set; }
        public virtual DbSet<VozilaDogadjajDetalji> VozilaDogadjajDetalji { get; set; }
        public virtual DbSet<VrstaKorisnika> VrstaKorisnika { get; set; }
        public virtual DbSet<Vrste> Vrste { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=RS2_Bilten;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Dogadjaj>(entity =>
            {
                entity.HasIndex(e => e.KategorijeId);

                entity.HasIndex(e => e.OrganizacionaJedinicaId);

                entity.HasIndex(e => e.PodorganizacionaJedinicaId);

                entity.HasIndex(e => e.VrsteId);

                entity.HasOne(d => d.Kategorije)
                    .WithMany(p => p.Dogadjaj)
                    .HasForeignKey(d => d.KategorijeId);

                entity.HasOne(d => d.OrganizacionaJedinica)
                    .WithMany(p => p.Dogadjaj)
                    .HasForeignKey(d => d.OrganizacionaJedinicaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PodorganizacionaJedinica)
                    .WithMany(p => p.Dogadjaj)
                    .HasForeignKey(d => d.PodorganizacionaJedinicaId);

                entity.HasOne(d => d.Vrste)
                    .WithMany(p => p.Dogadjaj)
                    .HasForeignKey(d => d.VrsteId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<DogadjajDetalji>(entity =>
            {
                entity.HasOne(d => d.Dogadjaj)
                    .WithMany(p => p.DogadjajDetalji)
                    .HasForeignKey(d => d.DogadjajId)
                    .HasConstraintName("FK_DogadjajId");
            });

            modelBuilder.Entity<DogadjajMjere>(entity =>
            {
                entity.HasOne(d => d.Dogadjaj)
                    .WithMany(p => p.DogadjajMjere)
                    .HasForeignKey(d => d.DogadjajId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DogadjajMjereId");

                entity.HasOne(d => d.Mjera)
                    .WithMany(p => p.DogadjajMjere)
                    .HasForeignKey(d => d.MjeraId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mjere_DogadjajId");
            });

            modelBuilder.Entity<DogadjajSlike>(entity =>
            {
                entity.HasKey(e => new { e.DogadjajId, e.SlikaId })
                    .HasName("PK__Dogadjaj__79F497674CE00DC7");

                entity.HasOne(d => d.Dogadjaj)
                    .WithMany(p => p.DogadjajSlike)
                    .HasForeignKey(d => d.DogadjajId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DogadjajSlike_DogadajId");

                entity.HasOne(d => d.Slika)
                    .WithMany(p => p.DogadjajSlike)
                    .HasForeignKey(d => d.SlikaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SlikaId_Dogadjaj");
            });

            modelBuilder.Entity<DogadjajVideo>(entity =>
            {
                entity.HasKey(e => new { e.DogadjajId, e.VideoId })
                    .HasName("PK__Dogadjaj__BDA02497A10ECB4E");

                entity.HasOne(d => d.Dogadjaj)
                    .WithMany(p => p.DogadjajVideo)
                    .HasForeignKey(d => d.DogadjajId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DogadjajV__Dogad__308E3499");

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.DogadjajVideo)
                    .HasForeignKey(d => d.VideoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DogadjajV__Video__318258D2");
            });

            modelBuilder.Entity<Korisnici>(entity =>
            {
                entity.HasIndex(e => e.VrstaKorisnikaId);

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Jmbg).HasColumnName("JMBG");

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.VrstaKorisnika)
                    .WithMany(p => p.Korisnici)
                    .HasForeignKey(d => d.VrstaKorisnikaId);
            });

            modelBuilder.Entity<Mjere>(entity =>
            {
                entity.HasIndex(e => e.KategorijeId);

                entity.HasOne(d => d.Kategorije)
                    .WithMany(p => p.Mjere)
                    .HasForeignKey(d => d.KategorijeId);
            });

            modelBuilder.Entity<Mugshot>(entity =>
            {
                entity.Property(e => e.MugshotPath)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Osoba>(entity =>
            {
                entity.Property(e => e.BrLicneKarte)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DatumRodjenja).HasColumnType("date");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Jmbg)
                    .IsRequired()
                    .HasColumnName("JMBG")
                    .HasMaxLength(13);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OsobeDogadjajDetalji>(entity =>
            {
                entity.HasKey(e => new { e.DogadjajDetaljiId, e.OsobaId })
                    .HasName("PK__OsobeDog__5EE0F3DD64569AAF");

                entity.Property(e => e.OsobaId).HasColumnName("OsobaID");

                entity.HasOne(d => d.DogadjajDetalji)
                    .WithMany(p => p.OsobeDogadjajDetalji)
                    .HasForeignKey(d => d.DogadjajDetaljiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OsobeDogadjajId");

                entity.HasOne(d => d.Osoba)
                    .WithMany(p => p.OsobeDogadjajDetalji)
                    .HasForeignKey(d => d.OsobaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Osoba_DogadjajId");
            });

            modelBuilder.Entity<OsobeMugshot>(entity =>
            {
                entity.HasKey(e => new { e.OsobaId, e.MugshotId })
                    .HasName("PK__OsobeMug__4DE06F5E10E4DC7F");

                entity.HasOne(d => d.Mugshot)
                    .WithMany(p => p.OsobeMugshot)
                    .HasForeignKey(d => d.MugshotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mugshot_MugshotId");

                entity.HasOne(d => d.Osoba)
                    .WithMany(p => p.OsobeMugshot)
                    .HasForeignKey(d => d.OsobaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Osoba_OsobaId");
            });

            modelBuilder.Entity<PodorganizacionaJedinica>(entity =>
            {
                entity.HasIndex(e => e.OrganizacionaJedinicaId);

                entity.HasOne(d => d.OrganizacionaJedinica)
                    .WithMany(p => p.PodorganizacionaJedinica)
                    .HasForeignKey(d => d.OrganizacionaJedinicaId);
            });

            modelBuilder.Entity<Slike>(entity =>
            {
                entity.Property(e => e.Slika).IsRequired();

                entity.Property(e => e.SlikaName).HasMaxLength(100);
            });

            modelBuilder.Entity<Video>(entity =>
            {
                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Vozila>(entity =>
            {
                entity.Property(e => e.BrRegOznake)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Marka)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<VozilaDogadjajDetalji>(entity =>
            {
                entity.HasKey(e => new { e.DogadjajDetaljiId, e.VoziloId })
                    .HasName("PK__VozilaDo__F4AE31CCD0A5C9EA");

                entity.HasOne(d => d.DogadjajDetalji)
                    .WithMany(p => p.VozilaDogadjajDetalji)
                    .HasForeignKey(d => d.DogadjajDetaljiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DogadjajDetaljiId");

                entity.HasOne(d => d.Vozilo)
                    .WithMany(p => p.VozilaDogadjajDetalji)
                    .HasForeignKey(d => d.VoziloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Detalji_VoziloId");
            });

            modelBuilder.Entity<Vrste>(entity =>
            {
                entity.HasIndex(e => e.KategorijeId);

                entity.HasOne(d => d.Kategorije)
                    .WithMany(p => p.Vrste)
                    .HasForeignKey(d => d.KategorijeId);
            });
        }
    }
}
