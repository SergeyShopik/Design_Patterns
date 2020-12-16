using System;

namespace Weather_App_Observer_Pattern_
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentDisplay =
                new CurrentConditionsDisplay(weatherData);
            StaticsticsDisplay staticsticsDisplay = new StaticsticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            HeatIndexDisplay heatIndex = new HeatIndexDisplay(weatherData);

            weatherData.SetMeasurements(20, 60, 30.01);
            weatherData.SetMeasurements(24, 55, 31.52);
            weatherData.SetMeasurements(28, 70, 27.84);

        }
    }
}
