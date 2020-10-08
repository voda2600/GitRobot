using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Calculator;

namespace FProxyC
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // + в GET запросах это %2B
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.MapWhen(context =>
            {

                return context.Request.Query.ContainsKey("a")  && context.Request.Query.ContainsKey("oper") &&
                        context.Request.Query.ContainsKey("b");
            }, Calculating);

            
            app.UseEndpoints(endpoints =>
            {
                app.Run( async context =>
                {
                    await context.Response.WriteAsync("Parameters for calculator not found!");
                });
            });
            static void Calculating(IApplicationBuilder app)
            {
                app.Run(async context =>
                {
                    string ans = "";
                    if (context.Request.Query["oper"] == "/" ||
                        context.Request.Query["oper"] == "+" || 
                        context.Request.Query["oper"] == "-" ||
                        context.Request.Query["oper"] == "*")
                        ans = (new Calc().Calculate(double.Parse(context.Request.Query["a"]), char.Parse(context.Request.Query["oper"]), double.Parse(context.Request.Query["b"]))).ToString();
                    else ans = "No found this \""+context.Request.Query["oper"].ToString()+"\" in calculator";
                    await context.Response.WriteAsync(ans);
                });
            }
        }
    }
}
