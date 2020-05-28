using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BiltenWebAPI.Database;
using BiltenWebAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using AutoMapper;
using Bilten.Model;
using Bilten.Model.Requests;
using Bilten.Model.Requests.Mjere;
using Bilten.Model.Requests.Kategorije;
using Bilten.Model.Requests.Vrste;
using Bilten.Model.Requests.Osoba;
using Bilten.Model.Requests.Vozila;
using Bilten.Model.Requests.OrganizacionaJedinica;
using Bilten.Model.Requests.PodorganizacionaJedinica;
using Bilten.Model.Requests.DogadjajiMjere;
using Bilten.Model.Requests.DogadjajDetalji;
using Bilten.Model.Requests.VozilaDogadjajDetalji;
using Bilten.Model.Requests.OsobeDogadjajDetalji;
using Bilten.Model.Requests.Slike;
using Bilten.Model.Requests.DogadjajSlike;
using Bilten.Model.Requests.Korisnici;
using BiltenWebAPI.Security;
using Microsoft.AspNetCore.Authentication;
using Swashbuckle.AspNetCore.SwaggerGen;
using Bilten.Model.Requests.VrstaKorisnika;
using Bilten.Model.Requests.Dogadjaj;
using Bilten.Model.Requests.Video;
using Bilten.Model.Requests.DogadjajVideo;
using Bilten.Model.Requests.Mugshot;
using Bilten.Model.Requests.OsobeMugshot;

namespace BiltenWebAPI
{
    public class BasicAuthDocumentFilter : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            var securityRequirements = new Dictionary<string, IEnumerable<string>>()
        {
            { "basic", new string[] { } }  // in swagger you specify empty list unless using OAuth2 scopes
        };

            swaggerDoc.Security = new[] { securityRequirements };
        }
    }
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddAutoMapper();


            services.AddAuthentication("BasicAuthentication")
              .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);



            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
                c.AddSecurityDefinition("basic", new BasicAuthScheme() { Type = "basic" });
                c.DocumentFilter<BasicAuthDocumentFilter>();
            });


            services.AddScoped<IKorisniciService, KorisniciService>();

            services.AddScoped<ICRUDService<Bilten.Model.Kategorije, object, KategorijeUpsertRequest, KategorijeUpsertRequest>,
                BaseCRUDService<Bilten.Model.Kategorije, object, Database.Kategorije, KategorijeUpsertRequest, KategorijeUpsertRequest>>();

            services.AddScoped<ICRUDService<Bilten.Model.Vrste, VrsteSearchRequest, VrsteUpsertRequest, VrsteUpsertRequest>, VrsteService>();

            services.AddScoped<ICRUDService<Bilten.Model.OrganizacionaJedinica, object, OrganizacionaJedinicaUpsertRequest, OrganizacionaJedinicaUpsertRequest>, BaseCRUDService<Bilten.Model.OrganizacionaJedinica, object,Database.OrganizacionaJedinica, OrganizacionaJedinicaUpsertRequest, OrganizacionaJedinicaUpsertRequest>>();

            services.AddScoped<ICRUDService<Bilten.Model.PodorganizacionaJedinica, PodorganizacionaJedinicaSearchRequest, PodorganizacionaJedinicaUpsertRequest, PodorganizacionaJedinicaUpsertRequest>, PodorganizacionaJedinicaService>();

            services.AddScoped<ICRUDService<Bilten.Model.Dogadjaj, DogadjajSearchRequest, DogadjajUpsertRequest, DogadjajUpsertRequest>, DogadjajService>();

            services.AddScoped<ICRUDService<Bilten.Model.Mjere, MjereSearchRequest, MjereUpsertRequest, MjereUpsertRequest>, MjereService>();

            services.AddScoped<ICRUDService<Bilten.Model.Osoba, OsobaSearchRequest, OsobaUpsertRequest, OsobaUpsertRequest>,OsobaService>();

            services.AddScoped<ICRUDService<Bilten.Model.Vozila, VozilaSearchRequest, VozilaUpsertRequest, VozilaUpsertRequest>, VozilaService>();

            services.AddScoped<ICRUDService<Bilten.Model.DogadjajMjere, DogadjajiMjereSearchRequest, DogadjajiMjereUpsertRequest, DogadjajiMjereUpsertRequest>, DogadjajiMjereService>();


            services.AddScoped<ICRUDService<Bilten.Model.DogadjajDetalji, DogadjajDetaljiSearchRequest, DogadjajDetaljiUpsertRequest, DogadjajDetaljiUpsertRequest>, DogadjajDetaljiService>(); ;

            services.AddScoped<ICRUDService<Bilten.Model.VozilaDogadjajDetalji, VozilaDogadjajDetaljiSearchRequest, VozilaDogadjajDetaljiUpsertRequest, VozilaDogadjajDetaljiUpsertRequest>, VozilaDogadjajDetaljiService>();

            services.AddScoped<ICRUDService<Bilten.Model.OsobeDogadjajDetalji, OsobeDogadjajDetaljiSearchRequest, OsobeDogadjajDetaljiUpsertRequest, OsobeDogadjajDetaljiUpsertRequest>, OsobeDogadjajDetaljiService>();

            services.AddScoped<ICRUDService<Bilten.Model.Slike, SlikeSearchRequest, SlikeUpsertRequest, SlikeUpsertRequest>, SlikeService>();

            services.AddScoped<ICRUDService<Bilten.Model.DogadjajSlike, DogadjajSlikeSearchRequest, DogadjajSlikeUpsertRequest, DogadjajSlikeUpsertRequest>, DogadjajSlikeService>();

            services.AddScoped<ICRUDService<Bilten.Model.VrstaKorisnika, object, object, object>, BaseCRUDService<Bilten.Model.VrstaKorisnika, object, Database.VrstaKorisnika, object, object>>();


            services.AddScoped<ICRUDService<Bilten.Model.Video, object, VideoUpsertRequest, VideoUpsertRequest>, VideoService>();

            services.AddScoped<ICRUDService<Bilten.Model.DogadjajVideo, DogadjajVideoSearchRequest, DogadjajVideoUpsertRequest, DogadjajVideoUpsertRequest>, DogadjajVideoService>();

            services.AddScoped<ICRUDService<Bilten.Model.Mugshot, MugshotSearchRequest, MugshotUpsertRequest, MugshotUpsertRequest>, MugshotService>();

            services.AddScoped<ICRUDService<Bilten.Model.OsobeMugshot, OsobeMugshotSearchRequest, OsobeMugshotUpsertRequest, OsobeMugshotUpsertRequest>, OsobeMugshotService>();


            //services.AddScoped<ICRUDService<Bilten.Model.Korisnici, object, KorisniciUpsertRequest, KorisniciUpsertRequest>, KorisniciService>();



            var connection = @"Server=.;Database=RS2_Bilten;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<RS2_BiltenContext>(options => options.UseSqlServer(connection));
        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");

            });

            app.UseAuthentication();

            //app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
