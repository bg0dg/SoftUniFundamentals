using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace _04._Weather
{
    class Weather
    {
        public double temperature { get; set; }
        public string weatherType { get; set; }

        public Weather(double temperatureConstr, string weatherTypeConstr)
        {
            temperature = temperatureConstr;
            weatherType = weatherTypeConstr;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string regexFilter = @"([A-Z]{2})(\d+\.\d+)([a-zA-Z]+)\|";

            Dictionary<string, Weather> forecast = new Dictionary<string, Weather>();

            while (inputString != "end")
            {

                if (Regex.IsMatch(inputString, regexFilter))
                {
                    var validInput = Regex.Match(inputString, regexFilter);
                    string validCityInput = validInput.Groups[1].ToString();
                    double validTemperInput = double.Parse(validInput.Groups[2].ToString());
                    string validWeatherTypeInput = validInput.Groups[3].ToString();
                    Weather weatherInstance = new Weather(validTemperInput, validWeatherTypeInput);

                    forecast[validCityInput] = weatherInstance;


                }

                inputString = Console.ReadLine();
            }

            foreach (var item in forecast.OrderBy(s => s.Value.temperature))
            {
                Console.WriteLine($"{item.Key} => {item.Value.temperature} => {item.Value.weatherType}");
            }
        }
    }
}
