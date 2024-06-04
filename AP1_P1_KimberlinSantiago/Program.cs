using Microsoft.Extensions.Hosting;

namespace AP1_P1_KimberlinSantiago
{
    public class Program
    {
        public static object Host { get; private set; }

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseUrls("http://localhost:7100");
                });
    }
}
