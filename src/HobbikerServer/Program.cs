using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace HobbikerServer
{
    // public class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         var host = new WebHostBuilder()
    //             .UseKestrel()
    //             .UseContentRoot(Directory.GetCurrentDirectory())
    //             .UseIISIntegration()
    //             .UseStartup<Startup>()
    //             .Build();

    //         host.Run();
    //     }
    // }
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    //webBuilder.UseStartup<StartupJavaScript>();
                });
    }
}
