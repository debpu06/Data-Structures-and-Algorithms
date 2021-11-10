using System;

namespace Patterns.Observer
{
    public interface IObserver
    {
        void Update(Object data);
    }
}