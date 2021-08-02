using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using PolicyAdmin.ConsumerMS.API.Data;
using PolicyAdmin.ConsumerMS.API.DataLayer;
using PolicyAdmin.ConsumerMS.API.Interface;
using PolicyAdmin.ConsumerMS.API.Provider;
using PolicyAdmin.ConsumerMS.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyAdmin.ConsumerMS.API
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

            if (Configuration.GetValue<bool>("InMemoryDatabase"))
            {
                services.AddDbContext<ConsumerContext>(options => options.UseInMemoryDatabase("PolicyAdmin_Quotes"));

            }
            else
            {
                services.AddDbContext<ConsumerContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Database")));
            }
            

            services.AddTransient<IConsumerDBService, ConsumerDBService>();
            services.AddTransient<IConsumerRepository, ConsumerRepository>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PolicyAdmin.ConsumerMS.API", Version = "v1" });
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PolicyAdmin.ConsumerMS.API v1"));
            }
            if (Configuration.GetValue<bool>("inmemorydatabase"))
            {
                var scopeeee = app.ApplicationServices.CreateScope();
                var context = scopeeee.ServiceProvider.GetRequiredService<ConsumerContext>();
                PropertyMasterDataGenerator.Initialize(context);
                businessMasterDataGenerator.Initialize(context);

            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
