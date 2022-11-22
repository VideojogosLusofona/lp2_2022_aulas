namespace Observers
{
    public interface ISubject<T>
    {
        void RegisterObserver(IObserver<T> obs);
        void RemoveObserver(IObserver<T> obs);
    }
}
