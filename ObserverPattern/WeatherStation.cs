using System.Collections.Generic;
using ObserverPattern.Interfaces;

namespace ObserverPattern
{
    public class WeatherStation : IObservable
    {
        private decimal _temperature;
        private decimal _humidity;
        private readonly List<IObserver> _subscribers = new List<IObserver>();

        public void Register(IObserver subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Deregister(IObserver subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public void Notify()
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update();
            }
        }

        public decimal Temperature
        {
            get { return _temperature; }
            set
            {
                _temperature = value;
                this.Notify();
            }
        }

        public decimal Humidity
        {
            get { return _humidity; }
            set
            {
                _humidity = value;
                this.Notify();
            }
        }
    }
}
