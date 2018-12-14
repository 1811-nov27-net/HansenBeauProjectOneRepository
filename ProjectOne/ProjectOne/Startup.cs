using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // configures AutoMapper at start-up
            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DataAccess.Customer, Models.Customer>();
                cfg.CreateMap<DataAccess.Address, Models.Address>();
                cfg.CreateMap<DataAccess.OrderHeader, Models.OrderHeader>();
                cfg.CreateMap<DataAccess.OrderDetail, Models.OrderDetail>();
                cfg.CreateMap<DataAccess.Product, Models.Product>();
                cfg.CreateMap<DataAccess.ProductRecipe, Models.ProductRecipe>();
                cfg.CreateMap<DataAccess.Ingredient, Models.Ingredient>();
                cfg.CreateMap<DataAccess.Inventory, Models.Inventory>();
                cfg.CreateMap<DataAccess.Store, Models.Store>();

                cfg.CreateMap<Models.Customer, DataAccess.Customer>();
                cfg.CreateMap<Models.Address, DataAccess.Address>();
                cfg.CreateMap<Models.OrderHeader, DataAccess.OrderHeader>();
                cfg.CreateMap<Models.OrderDetail, DataAccess.OrderDetail>();
                cfg.CreateMap<Models.Product, DataAccess.Product>();
                cfg.CreateMap<Models.ProductRecipe, DataAccess.ProductRecipe>();
                cfg.CreateMap<Models.Ingredient, DataAccess.Ingredient>();
                cfg.CreateMap<Models.Inventory, DataAccess.Inventory>();
                cfg.CreateMap<Models.Store, DataAccess.Store>();
            });
            AutoMapper.IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);
            services.AddMvc();

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
