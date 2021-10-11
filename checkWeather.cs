using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace findWeather
{
    public class checkWeather
    {
        private HttpClient aClient;

        public checkWeather(HttpClient  client)
        {
            aClient = client;
        }

        public string openWeather()
        {
            Console.WriteLine($"Please enter the api key to find weather information");
            var apiKey = Console.ReadLine();
            Console.WriteLine("Please enter the name of the city");
            var cityName = Console.ReadLine();
            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&units=imperial&appid={apiKey}";
            var weatherResponse = aClient.GetStringAsync(weatherURL).Result;
            var weatherObj = JObject.Parse(weatherResponse).GetValue("main").ToString();
            return weatherObj;
        }
    }
}
