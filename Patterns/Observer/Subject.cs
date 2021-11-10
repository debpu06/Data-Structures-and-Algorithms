using System.Collections.Generic;

namespace Patterns.Observer
{
    public abstract class Subject : ISubject
    {
        private List<IObserver> observers;
        protected Subject()
        {
            observers = new List<IObserver>();
        }
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void NotifyObservers(object data)
        {
            foreach(var observer in observers)
            {
                observer.Update(data);
            }
        }
    }
}