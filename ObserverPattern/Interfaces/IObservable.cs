namespace ObserverPattern.Interfaces
{
    public interface IObservable
    {
        void Register(IObserver subscriber);
        void Deregister(IObserver subscriber);
        void Notify();
    }
}
