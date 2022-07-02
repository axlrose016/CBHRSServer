using AXLSmartRepository.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using AXLSmartRepository.Core.Repositories;
using AXLSmartRepository.Persistence.Repositories;
using AXLSmartWebAPI.Classes;
using AXLSmartRepository.Core;
using AXLSmartWebAPI.Middlewares;
using AXLSmartWebAPI.ActionFilters;

namespace AXLSmartWebAPI
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
            services.AddCors();
            services.AddControllers();
            string conStr = Configuration["ConnectionStrings:DefaultConnection"];
            services.AddDbContext<PlutoContext>(opts => opts.UseLazyLoadingProxies().UseSqlServer(conStr, m => m.MigrationsAssembly("AXLSmartWebAPI")));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddTransient<ILibraryRepository, LibraryRepository>();
            services.AddTransient<IPerformanceRateRepository, PerformanceRateRepository>();
            services.AddScoped<CheckUserAccess>();

            STV.conStr = conStr;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(builder => builder
                .AllowAnyHeader()
                .AllowAnyMethod()
                .SetIsOriginAllowed((host) => true)
                .AllowCredentials()
            );
            app.UseMiddleware<CorsMiddleware>();

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
