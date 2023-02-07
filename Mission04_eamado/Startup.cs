using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04_eamado
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) //env is an environment (or an error page)
        {
            if(env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles(); //allows us to use our html page we created by typing /index.html in url
            app.UseRouting(); //routing uses endpoints that set up matches(almost like routes) for what the user types in.
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Blah}/{action=Index}/{id?}"   //returns the view of index in blahcontroller.cs. Its like a path/route but in c#
                    );
            });
            
        }
    }
}
