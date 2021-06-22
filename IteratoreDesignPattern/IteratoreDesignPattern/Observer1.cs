using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratoreDesignPattern
{
    class Observer1 : IObserver
    {
        public void update()
        {
            Console.WriteLine("Updated Observer 1");
        }
    }
}
