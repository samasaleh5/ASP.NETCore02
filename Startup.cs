using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCore02
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {//DI
            services.AddControllersWithViews();//apply MVC arch        
        }
            // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //life cycle=>pipelines=>middlewares
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();//Route Table 

            app.UseEndpoints(endpoints =>
            { //by default By APIS

                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});

                //Controller/Action (default)
                //1)variable segments 2)static 3)mixed
                endpoints.MapControllerRoute
                (
                    name:"Default",//name of route 
                    pattern:"{controller=Home}/{action=index}/{id:int?}"// (?) to make parameter optional
                    //defaults=new{controller=Movies,{action=index}
                );
            });
        }
    }
}
