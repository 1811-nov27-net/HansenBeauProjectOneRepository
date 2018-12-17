using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjectOne.DataAccess;
using ProjectOne.Repository;

namespace ProjectOne
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddScoped<IRepository, RepositoryDB>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddDbContext<ItaDPizzaContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("CSAlias")));

            // configures AutoMapper at start-up
            //var config = new AutoMapper.MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<DataAccess.Customer, Library.Customer>();
            //    cfg.CreateMap<DataAccess.Address, Library.Address>();
            //    cfg.CreateMap<DataAccess.OrderHeader, Library.OrderHeader>();
            //    cfg.CreateMap<DataAccess.OrderDetail, Library.OrderDetail>();
            //    cfg.CreateMap<DataAccess.Product, Library.Product>();
            //    cfg.CreateMap<DataAccess.ProductRecipe, Library.ProductRecipe>();
            //    cfg.CreateMap<DataAccess.Ingredient, Library.Ingredient>();
            //    cfg.CreateMap<DataAccess.Inventory, Library.Inventory>();
            //    cfg.CreateMap<DataAccess.Store, Library.Store>();

            //    cfg.CreateMap<Library.Customer, DataAccess.Customer>();
            //    cfg.CreateMap<Library.Address, DataAccess.Address>();
            //    cfg.CreateMap<Library.OrderHeader, DataAccess.OrderHeader>();
            //    cfg.CreateMap<Library.OrderDetail, DataAccess.OrderDetail>();
            //    cfg.CreateMap<Library.Product, DataAccess.Product>();
            //    cfg.CreateMap<Library.ProductRecipe, DataAccess.ProductRecipe>();
            //    cfg.CreateMap<Library.Ingredient, DataAccess.Ingredient>();
            //    cfg.CreateMap<Library.Inventory, DataAccess.Inventory>();
            //    cfg.CreateMap<Library.Store, DataAccess.Store>();
            //});
            //AutoMapper.IMapper mapper = config.CreateMapper();
            //services.AddSingleton(mapper);
            //services.AddMvc();

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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {            
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
