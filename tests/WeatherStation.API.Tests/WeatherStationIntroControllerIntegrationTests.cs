using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace WeatherStation.API.Tests
{
    public class WeatherStationIntroControllerIntegrationTests: IClassFixture<TestWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _httpClient;

        public WeatherStationIntroControllerIntegrationTests(TestWebApplicationFactory<Startup> applicationFactory)
        {
            _httpClient = applicationFactory.CreateClient();
        }

        [Fact]
        public async Task BaseRoute_ReturnsIntroduction()
        {
            HttpResponseMessage httpResponse = await _httpClient.GetAsync("/");
            httpResponse.EnsureSuccessStatusCode();

            string responseBody = await httpResponse.Content.ReadAsStringAsync();
            Assert.Equal("This is the weather station.", responseBody);
        }
    }
}