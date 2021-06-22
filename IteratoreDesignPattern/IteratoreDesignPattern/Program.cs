using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratoreDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IObserver obs1 = new Observer1();
            IObserver obs2 = new Observer2();

            ISubject sub = new Subject();
            sub.AddObservers(obs1);
            sub.AddObservers(obs2);
            sub.Notify();

            sub.DetachObserver(obs1);
            sub.Notify();

            Console.Read();


        }
    }
}
