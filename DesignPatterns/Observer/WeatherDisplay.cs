using System;

namespace DesignPatternsAssignment.Observer
{
    public class WeatherDisplay : IObserver
    {
        private string displayName;

        public WeatherDisplay(string name)
        {
            displayName = name;
        }

        public void Update(float temperature)
        {
            Console.WriteLine($"{displayName} received temperature: {temperature}°C");
        }
    }
}
