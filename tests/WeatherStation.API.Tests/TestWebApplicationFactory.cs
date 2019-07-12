using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;

namespace WeatherStation.API.Tests
{
    public class TestWebApplicationFactory<TStartup>: WebApplicationFactory<Startup>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                // Build the service provider.
                services.BuildServiceProvider();
            });
        }
    }
}