using AsyncAwait.Infrascrtucture;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait.Service
{
    public class WeatherForecastService
    {
        public async static void GetAllAsync()
        {
            try
            {
                using (var context = new ApplicationContext())
                {

                    var weathers = await context.WeatherForecast
                                   .OrderBy(e => e.Date)
                                   .ToListAsync().ConfigureAwait(false);

                    ShowWeather(weathers);
                    Console.WriteLine("Processado Async.");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal static void Charge()
        {
            using (var context = new ApplicationContext())
            {
                for (int i = 0; i < 100; i++)
                {
                    var weather = new WeatherForecast()
                    {
                        Date = DateTime.Now,
                        Summary = "",
                        TemperatureC = new Random(12).Next()
                    };

                    context.WeatherForecast.Add(weather);
                }

                context.SaveChanges();               
            
            }
        }

        internal static void GetAll()
        {
            try
            {
                using (var context = new ApplicationContext())
                {

                    var weathers = context.WeatherForecast
                                   .OrderBy(e => e.Date)
                                   .ToList();

                    ShowWeather(weathers);

                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private static void ShowWeather(List<WeatherForecast> weathers)
        {
            foreach (var weather in weathers)
            {
                Console.WriteLine(weather.ToString());
            }
        }

    }
}
