using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightDesignPattern
{
    class Terrorist : IPlayer
    {
        public void Mission()
        {
            Console.WriteLine("Kill Police");
        }
    }
}
