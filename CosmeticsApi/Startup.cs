using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cosmetics.Application.Services.Dto.Output;
using Cosmetics.Application.Services.Mapper;
using Cosmetics.EF.Persistance.CosmeticsDatabase;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CosmeticsApi
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
            services.AddAutoMapper(typeof(ProductInputMapper));
            services.AddAutoMapper(typeof(ProductOutputMapper));
            services.AddAutoMapper(typeof(CategoryInputMapper));
            services.AddAutoMapper(typeof(CategoryOutputDto));
            services.AddAutoMapper(typeof(StoreInputMapper));
            services.AddAutoMapper(typeof(StoreOutputDto));
            services.AddAutoMapper(typeof(UserInputMapper));
            services.AddAutoMapper(typeof(UserOutputDto));
            services.AddAutoMapper(typeof(CommentInputMapper));
            services.AddAutoMapper(typeof(CommentOutputMapper));


            services.AddDbContext<AppDBContext>
            (o => o.UseSqlServer(Configuration.GetConnectionString("CosmeticsDb")));
            services.AddControllers();
        }

      
  
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
