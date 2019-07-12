using Microsoft.AspNetCore.Mvc;

namespace WeatherStation.API
{
    [Route("/")]
    public class WeatherStationIntroController : ControllerBase
    {
        [HttpGet]
        public string WeatherStationIntroduction() => "This is the weather station.";
    }
}

