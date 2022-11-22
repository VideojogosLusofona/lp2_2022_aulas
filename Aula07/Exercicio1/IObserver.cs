namespace Observers
{
    public interface IObserver<T>
    {
        void Update(T sub);
    }
}
