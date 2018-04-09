using System;
using ObserverPattern.Interfaces;

namespace ObserverPattern
{
    public class PhoneApp : IObserver
    {
        private decimal _temperature;
        private decimal _humidity;

        private readonly WeatherStation _weatherStation;

        public PhoneApp(IObservable publisher)
        {
            var weatherStation = (WeatherStation) publisher;
            _weatherStation = weatherStation;
        }

        public void Update()
        {
            _temperature = _weatherStation.Temperature;
            _humidity = _weatherStation.Humidity;
        }

        public void Display()
        {
            Console.WriteLine($"Temperature: {_temperature}");
            Console.WriteLine($"Humidity: {_humidity}");
            Console.WriteLine();
        }
    }
}
