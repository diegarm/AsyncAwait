using System;
using System.Text;

namespace AsyncAwait.Infrascrtucture
{
    public class WeatherForecast
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF { get; private set; }
        public string Summary { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  TemperatureC: ").Append(TemperatureC).Append("\n");
            sb.Append("  TemperatureF: ").Append(TemperatureF).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("-------------------\n");
            return sb.ToString();
        }


    }
}
