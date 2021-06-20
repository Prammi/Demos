using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightDesignPattern
{
    class AntiTerrorist : IPlayer
    {
        public void Mission()
        {
            Console.WriteLine("Kill Terrorist");
        }
    }
}
