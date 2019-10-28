using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace SeleniumASPNetCore3
{
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
                    ConfigureWebHost(webBuilder);
                });

        //Used by testing tools to initialize an in-memory server for testing
        public static IWebHostBuilder ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.UseStartup<Startup>();

            return builder;
        }
    }
}