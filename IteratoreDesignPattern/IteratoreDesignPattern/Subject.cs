using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratoreDesignPattern
{
    class Subject : ISubject
    {
      private  List<IObserver> _observers = new List<IObserver>();
        public void AddObservers(IObserver obs)
        {
            _observers.Add(obs);
        }

        public void DetachObserver(IObserver obs)
        {
            _observers.Remove(obs);
        }


        public void Notify()
        {
          foreach(IObserver obs in _observers)
            {
                obs.update();
            }
        }
    }
}
