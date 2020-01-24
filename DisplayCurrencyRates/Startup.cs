using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DisplayCurrencyRates.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DisplayCurrencyRates
{
    public class Startup 
    {
        private readonly IConfiguration _config;
        public Startup(IConfiguration config)
        {
            _config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CurrencyContext>( cfg => {
                cfg.UseSqlServer(_config.GetConnectionString("BitCoinIndexConnectionString"));
            });
            services.AddMvc();
            services.AddRouting(options =>
            {
                options.ConstraintMap.Add("start", typeof(DateTime));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();
            app.UseNodeModules(env);
            app.UseMvc(routes =>
            {
                //routes.MapRoute(
                //    name: "default",
                //    template:"{controller=Currency}/{action=GetRates}"
                //    );
                routes.MapRoute(
                           name: "getrates",
                           template: "Currency/GetRates/{start}",
                           defaults: new { controller = "Currency", action = "GetRates" , start = DateTime.Now.AddDays(-14) });
                          
            });

        }
    }
}
