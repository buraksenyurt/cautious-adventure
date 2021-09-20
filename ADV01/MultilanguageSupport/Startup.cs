using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace MultilanguageSupport
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
            // Çoklu dil desteği için middleware tarafına gerekli servis eklenir
            services.AddLocalization(options =>
            {
                options.ResourcesPath = "Resources"; // çoklu dil desteğine ait dosyaların duracağı klasör
            });

            services.AddControllersWithViews()
                .AddViewLocalization(); // View tarafı için çoklu dil desteği veren servis eklenir

            // Çoklu dil desteği için gerekli kültür ayarları yapılır.
            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new RequestCulture("en-US");

                // İngilizce, Türkçe ve İspanyolca dilleri desteklenecek
                var cultures = new CultureInfo[]
                {
                    new CultureInfo("en-US"),
                    new CultureInfo("tr-TR"),
                    new CultureInfo("es-ES")
                };

                options.SupportedCultures = cultures;
                options.SupportedUICultures = cultures;
            });
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseRequestLocalization(); // Çoklu dil desteği etkinleştirilir
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

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
