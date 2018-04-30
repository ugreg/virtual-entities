using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using VirutalEntityDemo.Models;

namespace VirutalEntityDemo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, WebOrderModelBuilder webOrderModelBuilder)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // var builder = new ODataConventionModelBuilder();
            // var entitySet = builder.EntitySet<WebOrder>("WebOrder");
            // entitySet.EntityType.HasKey(entity => entity.Id);

            app.UseMvc(routeBuilder =>
            {
                routeBuilder.MapODataServiceRoute("ODataRoutes", "odata", webOrderModelBuilder.GetEdmModel(app.ApplicationServices));
            });
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<WebOrderDbContext>(dbContextOptionsBuilder =>
            {
                dbContextOptionsBuilder.UseSqlite("Data Source=WebOrder.db");
            });

            services.AddOData();
            services.AddTransient<WebOrderModelBuilder>();
            services.AddMvc().AddJsonOptions(mvcJsonOptions =>
            {
                mvcJsonOptions.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                mvcJsonOptions.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });
        }               
    }
}
