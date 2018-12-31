using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace HappyNewYear2018
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddSomeCoolFeature()
                //.AddSingleton<IYearStrategy, Strategy2017>()
                //.AddSingleton<IYearStrategy, Strategy2018>()
                .AddSingleton<IYearStrategy, Strategy2019>()
                ;
            // ...
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }

    public interface IYearStrategy
    {

    }

    public class Strategy2017 : IYearStrategy
    {

    }

    public class Strategy2018 : IYearStrategy
    {

    }

    public class Strategy2019 : IYearStrategy
    {

    }

    public static class MyClass
    {
        public static IServiceCollection AddSomeCoolFeature(this IServiceCollection services)
        {
            return services;
        }
    }
}
