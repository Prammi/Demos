using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratergyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Sparky = new Dog();
            Animal Birdie = new Bird();
            Console.WriteLine("dog Name = " + Sparky.Name + " Flying Prop = "+Sparky.FlyingProperty.Flys() );
            Console.WriteLine("Bird Name = " + Birdie.Name + " Flying Prop = " + Birdie.FlyingProperty.Flys());
            Console.Read();

        }
    }
}
