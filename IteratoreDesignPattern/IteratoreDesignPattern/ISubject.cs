using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratoreDesignPattern
{
    interface ISubject
    {
        void AddObservers(IObserver obs);
        void Notify();

        void DetachObserver(IObserver obs);
    }
}
