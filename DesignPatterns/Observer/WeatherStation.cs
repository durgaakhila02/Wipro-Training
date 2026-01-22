using System.Collections.Generic;

namespace DesignPatternsAssignment.Observer
{
    public class WeatherStation : ISubject
    {
        private List<IObserver> observers = new();
        private float temperature;

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void SetTemperature(float temp)
        {
            temperature = temp;
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature);
            }
        }
    }
}
