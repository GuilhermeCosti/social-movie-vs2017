using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.IO;
using Microsoft.Extensions.FileProviders;
using Microsoft.AspNetCore.StaticFiles;
using SocialMovie.Models;
using Microsoft.Extensions.Configuration;
using MySQL.Data.EntityFrameworkCore.Extensions;

namespace SocialMovie
{
    public class Startup
    {
        private IHostingEnvironment _env;
        private IConfigurationRoot Configuration;

        public Startup(IHostingEnvironment env)
        {
            _env = env;

            var builder = new ConfigurationBuilder()
                .SetBasePath(_env.ContentRootPath)
                .AddJsonFile("config.json")
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<SocialMovieContext>();
            string url = "";

            if (_env.IsDevelopment())
            {
                services.AddDirectoryBrowser();
                url = Configuration.GetValue<string>("localUrl");
            } else
            {

                url = Configuration.GetValue<string>("releaseUrl");
            }

            services.AddDbContext<SocialMovieContext>(options =>
            {
                options.UseMySQL($"server={url};userid=root;pwd=joaopio1234;port=3306;database=socialmovie;sslmode=none;");
            });
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseDeveloperExceptionPage();
            app.UseDefaultFiles();
            app.UseStaticFiles(new StaticFileOptions() {
                ServeUnknownFileTypes = true
            });
            //app.UseFileServer(new FileServerOptions() {
            //    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"Movies")),
            //    RequestPath = new PathString("/movies"),
            //    EnableDirectoryBrowsing = true,
            //});

            //app.UseStaticFiles(new StaticFileOptions()
            //{
            //    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"Movies")),
            //    RequestPath = new PathString("/movies"),
            //    ServeUnknownFileTypes = true
            //});


            app.UseCookieAuthentication(new CookieAuthenticationOptions()
            {
                AuthenticationScheme = "MyCookieMiddlewareInstance",
                LoginPath = new PathString("/Account/Unauthorized/"),
                AccessDeniedPath = new PathString("/Account/Forbidden/"),
                AutomaticAuthenticate = true,
                AutomaticChallenge = true
            });

            app.UseMvcWithDefaultRoute();


        }
    }
}
