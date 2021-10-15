using AsyncAwait.Service;
using System;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {

            //WeatherForecastService.Charge();

            Console.WriteLine("Informe A - Async ou S - Sync");            

            var arg = Console.ReadLine().ToLower();

            if(arg.Contains("a") || arg.Contains("s"))
            {
                if (arg.Equals("a"))
                {
                    Console.WriteLine("Processando Async");
                    WeatherForecastService.GetAllAsync();
                    Console.WriteLine("Processando...");

                }
                else
                {
                    Console.WriteLine("Processando Sync");
                    WeatherForecastService.GetAll();
                    Console.WriteLine("Processado");
                }

                
            }
            else{
                Console.WriteLine("Comando inválido");
            }

            Console.Read();

            
        }
    }
}
