using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IBird _bird = new Bird();
            IToy _toy = new Toy();
            Console.WriteLine("post Impersonation");
            BirdAdpater impersonateToy = new BirdAdpater(_bird);
            impersonateToy.makeSound();
            Console.Read();

        }
    }
}
