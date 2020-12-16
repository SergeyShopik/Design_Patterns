using System;
using System.Collections.Generic;
using System.Text;
//using System.Private.CoreLib.dll;

namespace Weather_App_Observer_Pattern_
{
    //WeatherData contains list of observers, all information they need
    //and methods to interact with observers
    public class WeatherData : Subject
    {
        private List<Observer> observers;
        private double temperature;
        private double humidity;
        private double pressure;

        public WeatherData()
        {
            observers = new List<Observer>();
        }

        public void RegisterObserver(Observer o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(Observer o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0 || i < observers.Count)
            {
                observers.RemoveAt(i);
            }
            //out of range exception handling is required
        }
        public void NotifyObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }
        public void SetMeasurements(double t, double h, double p)
        {
            temperature = t;
            humidity = h;
            pressure = p;
            MeasurementsChanged();
        }
    }
}
