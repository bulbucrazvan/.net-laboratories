using Kata04.PartOne;
using Kata04.PartTwo;
using System;

namespace Kata04
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData("weather.dat");
            FootballData footballData = new FootballData("football.dat");
            Console.WriteLine("Weather Data output: " + weatherData.GetSmallestSpreadDay());
            Console.WriteLine("Football Data output: " + footballData.GetBestTeam());
        }
    }
}
