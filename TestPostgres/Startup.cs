using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using TestPostgres.DataAccess;
using TestPostgres.Interfaces;

namespace TestPostgres
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
            services.AddControllers();
            //var sqlConnectionString = Configuration["Server=localhost; Port=5432; Database=postgres; User Id=postgres; Password=siddhant;"];
            //services.AddDbContext<PostgreSqlContext>(options => options.UseNpgsql("Server=localhost; Port=5432; Database=postgres; User Id=postgres; Password=siddhant;"));
            services.AddDbContext<PostgreSqlContext>(options => options.UseNpgsql("Server=rb-database-1.cabwget0lo8p.ap-south-1.rds.amazonaws.com; Port=5432; Database=postgres; User Id=rbelect; Password=cpAqil9vrSKMHRd1KggY;"));
            services.AddScoped<IDataAccessProvider, DataAccessProvider>();
        
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TestPostgres", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TestPostgres v1"));
            }

           // app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
