using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BCA.Northwind.Business.Abstract;
using BCA.Northwind.Business.Concrete;
using BCA.Northwind.DaraAccess.Abstract;
using BCA.Northwind.DaraAccess.Concrete;
using BCA.Northwind.MvcWebUI.Entities;
using BCA.Northwind.MvcWebUI.Middlewares;
using BCA.Northwind.MvcWebUI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BCA.Northwind.MvcWebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddSingleton<ICartSessionService, CartSessionService>();
           
            services.AddScoped<ICartService, CartManager>();
            services.AddDbContext<CustomIdentityDbContext>
             (options => options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true"));
            services.AddIdentity<CustomIdentityUser, CustomIdentityRole>()
                .AddEntityFrameworkStores<CustomIdentityDbContext>()
                .AddDefaultTokenProviders();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddMvc();
            services.AddSession();
            
            services.AddDistributedMemoryCache();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseFileServer();
            app.UseNodeModules(env.ContentRootPath);
            app.UseIdentity();
            app.UseSession();
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(ConfigureRoutes);


        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            //Home/Index
            routeBuilder.MapRoute("Default", "{controller=Product}/{action=Index}/{id?}");
        }
    }
}
