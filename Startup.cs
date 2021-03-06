using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using OnlineShop_DotNet.Data.interfaces;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using OnlineShop_DotNet.Data;
using OnlineShop_DotNet.Data.Repository;
using OnlineShop_DotNet.Data.Models;

namespace OnlineShop_DotNet
{
    public class Startup
    {

        private IConfigurationRoot _confString;

        public Startup(IHostingEnvironment hostEnv)
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAllСomputerСomponents, СomputerСomponentRepository>();
            services.AddTransient<IСomputerСomponentsCategory, CategoryRepository>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<IAllOrders, OrdersRepository>();
            services.AddScoped(sp => ShopCart.GetCart(sp));
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddMemoryCache();
            services.AddSession();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(name: "categoryFilter", template: "СomputerСomponents/{action}/{category?}", defaults: new { Controller = "СomputerСomponents", action = "List" });
            });
            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                DBObjects.Initial(content);
            }
        }
    }
}