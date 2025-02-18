
using Autofac.Extensions.DependencyInjection;

namespace MillenniumTask;

public class Program
{
    public static async Task Main(string[] args)
    {
        var host = Host.CreateDefaultBuilder(args)
            .ConfigureLogging(l=> l.SetMinimumLevel(LogLevel.Trace))
            .UseServiceProviderFactory(new AutofacServiceProviderFactory())
            .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>())
            .Build();
        
        await host.RunAsync();
    }
}