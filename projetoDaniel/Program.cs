using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace projetoDaniel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PCreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder PCreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
