using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    class Bird : IBird
    {
        public void fly()
        {
            Console.WriteLine("Bird Can Fly");
        }

        public void makeSound()
        {
            Console.WriteLine("Sound Made by Bird");
        }
    }
}
