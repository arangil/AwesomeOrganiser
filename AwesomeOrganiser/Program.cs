using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using AwesomeOrganiser.Models;
using Microsoft.Extensions.Hosting;

namespace AwesomeOrganiser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();

            //Does not Work
            //https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/working-with-sql?view=aspnetcore-2.1&tabs=aspnetcore2x
            //using (var scope = host.Services.CreateScope())
            //{
            //    var services = scope.ServiceProvider;

            //    try
            //    {
            //        var context = services.GetRequiredService<context>();
            //        context.Database.Migrate();
            //        SeedData.Initialize(services);
            //    }
            //    catch (Exception ex)
            //    {
            //        var logger = services.GetRequiredService<ILogger<Program>>();
            //        logger.LogError(ex, "An error occurred seeding the DB.");
            //    }
            //}
            //host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
                

    }
}
