using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using SocialMovie.Models;
using System.Net;

namespace SocialMovie
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel(
                    options =>
                    {
                        options.AddServerHeader = false;
                        options.Listen(IPAddress.Loopback, 5000, listenOptions =>
                        {
                            listenOptions.UseHttps("localhost.pfx", "joaopio1234");
                        });
                    }
                )
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .UseApplicationInsights()
                .UseUrls("https://localhost:5000")
                .Build();

            host.Run();
        }
    }
}
