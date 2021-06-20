using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    class Toy : IToy
    {
        public void sqeak()
        {
            Console.WriteLine("Toy Squeaked");
        }
    }
}
