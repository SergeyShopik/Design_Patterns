using System;
using System.Collections.Generic;
using System.Text;

namespace Weather_App_Observer_Pattern_
{
    public class StaticsticsDisplay : Observer, DisplayElement
    {
        private double maxTemp = -50;
        private double minTemp = 50;
        private double tempSum = 0;
        private int numReadings;
        private Subject weatherData;

        public StaticsticsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(double temp, double humidity, double pressure)
        {
            tempSum += temp;
            numReadings++;

            if (temp > maxTemp)
            {
                maxTemp = temp;
            }
            if (temp < minTemp)
            {
                minTemp = temp;
            }

            Display();
        }
        public void Display()
        {
            Console.WriteLine($"Avg/Min/Max temperature = {tempSum / numReadings}" +
                $"/{minTemp}/{maxTemp}");
        }
    }
}
