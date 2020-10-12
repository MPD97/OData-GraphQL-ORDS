using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_GraphQL.Services;
using AutoMapper;
using DatabaseLibrary;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace API_GraphQL
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ExampleContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("LocalDB")));

            services.AddScoped<PersonRepository>();
            
            services.AddAutoMapper(c=>c.AddProfile<AutoMapping>(),typeof(Startup));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ExampleContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
       
    }
}