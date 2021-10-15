using System;

namespace AsyncAwait.Infrascrtucture
{
    public class WeatherForecast
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF { get; private set; }
        public string Summary { get; set; }

    }
}
