using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna
{
    public class Startup
    {
       
       
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

       
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    "default",
                    "{controller=home}/{action=index}/{id?}");

               


                endpoints.MapControllerRoute(
                   name: "Home",
                   pattern: "index.html",
                   defaults:new { controller="home", action="index"}
                   );


                endpoints.MapControllerRoute(
                   name: "about",
                   pattern: "about.html",
                   defaults: new { controller = "about", action = "about" }
                   );


                endpoints.MapControllerRoute(
                  name: "Services",
                  pattern: "services.html",
                  defaults: new { controller = "services", action = "services" }
                  );


                endpoints.MapControllerRoute(
                 name: "Portfolio",
                 pattern: "portfolio.html",
                 defaults: new { controller = "portfolio", action = "portfolio" }
                 );


                endpoints.MapControllerRoute(
                name: "Team",
                pattern: "team.html",
                defaults: new { controller = "team", action = "team" }
                );


                endpoints.MapControllerRoute(
                name: "Pircing",
                pattern: "pricing.html",
                defaults: new { controller = "pircing", action = "pircing" }
                );


                endpoints.MapControllerRoute(
                name: "Blog",
                pattern: "blog.html",
                defaults: new { controller = "blog", action = "blog" }
                );


                endpoints.MapControllerRoute(
                name: "contact",
                pattern: "contact.html",
                defaults: new { controller = "contact", action = "contact" }
                );



            });
        }
    }
}
