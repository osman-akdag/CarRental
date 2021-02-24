using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
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

            services.AddSingleton<IBrandDal,EfBrandDal>();
            services.AddSingleton<ICarDal, EfCarDal>();
            services.AddSingleton<IColorDal, EfColorDal>();
            services.AddSingleton<ICustomerDal, EfCustomerDal>();
            services.AddSingleton<IRentalDal, EfRentalDal>();
            services.AddSingleton<IUserDal, EfUserDal>();

            
            services.AddSingleton<IBrandService, BrandManager>();
            services.AddSingleton<ICarService, CarManager>();
            services.AddSingleton<IColorService, ColorManager>();
            services.AddSingleton<ICustomerService, CustomerManager>();
            services.AddSingleton<IRentalService, RentalManager>();
            services.AddSingleton<IUserService,UserManager>();

            services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });

            services.AddSwaggerDocument(p => 
                {
                    p.DocumentName = "RentalCarAPI";
                    p.Title = "RentalCarAPI";
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseOpenApi();
            app.UseSwaggerUi3();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
