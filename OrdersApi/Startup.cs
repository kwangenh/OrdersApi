using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OrdersApi.Models;
using OrdersApi.Repositories;
using OrdersApi.Contracts;
using Microsoft.EntityFrameworkCore;


namespace OrdersApi
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        private IConfiguration _config;
        public Startup (IConfiguration config)
        {
            _config = config;
        }


        // needed to manually add microsoft.entityframeworkcore.sqlserver nuget package
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.ConfigureCors();
            services.RegisterRepos();

            services.AddDbContextPool<OrdersDb>(options => options.UseSqlServer(_config.GetConnectionString("OrdersDb")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
