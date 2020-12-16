using System;
using System.Collections.Generic;
using System.Text;

namespace Weather_App_Observer_Pattern_
{
    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private double temperature;
        private double humidity;
        private Subject weatherData;

        public CurrentConditionsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(double temp, double humidity, double pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }
        public void Display()
        {
            Console.WriteLine($"Current conditions: {temperature} degrees C and {humidity}" +
                $" humidity.");
        }
    }
}
