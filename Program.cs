using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace findWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            var checkedWeather = new checkWeather(client);
            Console.WriteLine();
            var weather = checkedWeather.openWeather();
            Console.WriteLine($"Todays weather is  {weather}");
        }
    }
}
