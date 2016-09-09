using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace FirstApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
            .UseKestrel()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .UseStartup<StartUp>()
            .Build();

            host.Run();
        }
    }
}
