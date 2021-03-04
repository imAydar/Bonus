using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using Bonus.Core.Services;
using Bonus.Core.Services.Interfaces;
using Bonus.Data;
using Bonus.Data.Models;
using Bonus.Data.Repositories;
using Bonus.Web.Controllers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using Card = Bonus.Core.Services.Card;
using Customer = Bonus.Core.Services.Customer;
using Store = Bonus.Core.Services.Store;

namespace Bonus.Web
{
    public class Startup
    {
        //private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo {Title = "Bonus.Web", Version = "v1"}); });
            services.AddEntityFrameworkNpgsql().AddDbContext<Bonus.Data.ApplicationDbContext>(opt =>
                opt.UseNpgsql(Configuration.GetConnectionString("MyWebApiConection"),
                    b => b.MigrationsAssembly("Bonus.Web")));
            
            services.AddScoped<ICardRepository, CardRepository>();
            services.AddScoped<ICard, Card>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICustomer, Customer>();
            services.AddScoped<IStoreRepository, StoreRepository>();
            services.AddScoped<IStore, Store>();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Bonus.Web v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }

}