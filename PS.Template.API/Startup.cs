using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PS.Template.AccessData;
using PS.Template.AccessData.Commands;
using PS.Template.AccessData.Queries;
using PS.Template.Application.Services;
using PS.Template.Domain.Commands;
using Template.AccessData.Queries;


namespace PS.Template.API
{
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
            services.AddCors(c => c.AddDefaultPolicy(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));
            services.AddControllers();
            var connectionString = Configuration.GetSection("ConnectionString").Value;
            services.AddDbContext<TemplateDbContext>(options => options.UseSqlServer(connectionString));

            services.AddTransient<IGenericsRepository, GenericsRepository>();
            services.AddTransient<IEspecialidadService, EspecialidadService>();
            services.AddTransient<IEspecialidadQueries, EspecialidadQueries>();
            services.AddTransient<IClinicaService, ClinicaService>();
            services.AddTransient<IClinicaQueries, ClinicaQueries>();
            services.AddTransient<IMedicoService, MedicoService>();
            services.AddTransient<IMedicoQueries, MedicoQueries>();
            

           


            //services.AddSwaggerGen();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
