using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    class BirdAdpater
    {
        IBird B;
        public BirdAdpater(IBird b)
        {
            this.B = b;
        }

        public void makeSound()
        {
            B.makeSound();
        }
    }
}
