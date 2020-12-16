using System;
using System.Collections.Generic;
using System.Text;

namespace Weather_App_Observer_Pattern_
{
    public class ForecastDisplay : Observer, DisplayElement
    {
        private double currentPressure = 29.92;
        private double lastPressure;
        private Subject weatherData;

        public ForecastDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(double temp, double humidity, double pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;

            Display();
        }
        public void Display()
        {
            Console.WriteLine("Forecast: ");
            if (currentPressure > lastPressure)
            {
                Console.WriteLine("Weather is improving!");
            } else if (currentPressure == lastPressure)
            {
                Console.WriteLine("More of the same.");
            } else
            {
                Console.WriteLine("Gonna be cooler and rainy");
            }
        }
    }
}
