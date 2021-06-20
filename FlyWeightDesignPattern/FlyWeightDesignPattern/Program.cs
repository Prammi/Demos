using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            for(int i = 0; i < 10; i++)
            {
                IPlayer player = FlyWeightFactory.GetPlayer("terrorist");
                IPlayer player2 = FlyWeightFactory.GetPlayer("terrorist");

            }
        }
    }
}
