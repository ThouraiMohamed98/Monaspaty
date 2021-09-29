using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MonaspatyF.Models;
using MonaspatyF.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace MonaspatyF
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
            //-------------------------------------------------- Register DB --------------------------------------------------
            services.AddDbContext<MonaspatyContext>(option => option.UseLazyLoadingProxies().UseSqlServer(Configuration.GetConnectionString("Monaspaty")));

            services.AddControllersWithViews();
            //services.AddMvc();

            //---------------------------Repository-------------------------------------------------------
            services.AddScoped<HSORepository, HSORepository>();
            services.AddScoped<MessageRepository, MessageRepository>();
            services.AddScoped<cookies, cookies>();
            services.AddScoped<Helper, Helper>();

            //---------------------------Session-------------------------------------------------------
            services.AddSession(option=>option.IdleTimeout=TimeSpan.FromSeconds(20));

            //---------------------------cookie-------------------------------------------------------
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //services.AddHttpContextAccessor();

            //---------------------------identity-------------------------------------------------------
            //services.AddAuthorization(options =>
            //{
            //    options.FallbackPolicy = new AuthorizationPolicyBuilder()
            //        .RequireAuthenticatedUser()
            //        .Build();
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            //---------------------------Session-------------------------------------------------------
            app.UseSession();

            app.UseRouting();

            //-----------------------------cookie-------------------------------------------------------
            app.UseCookiePolicy();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
