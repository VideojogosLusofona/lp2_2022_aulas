using System.Collections.Generic;

namespace Observers
{
    public abstract class AbstractStringSubject : ISubject<AbstractStringSubject>
    {
        private readonly ICollection<IObserver<AbstractStringSubject>> observers;

        private string key;

        public string Key
        {
            get => key;
            protected set
            {
                key = value;
                foreach (IObserver<AbstractStringSubject> obs in observers)
                {
                    obs.Update(this);
                }
            }
        }

        protected AbstractStringSubject()
        {
            observers = new List<IObserver<AbstractStringSubject>>();
        }

        public void RegisterObserver(IObserver<AbstractStringSubject> obs)
        {
            observers.Add(obs);
        }

        public void RemoveObserver(IObserver<AbstractStringSubject> obs)
        {
            observers.Remove(obs);
        }
    }
}