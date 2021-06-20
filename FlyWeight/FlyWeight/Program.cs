using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class Program
    {
        private static String[] playerType = { "Terrorist", "CounterTerrorist" };
        private static String[] weapons = { "AK-47", "Maverick", "Gut Knife", "Desert Eagle" };

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                IPlayer p = null;
                if (i % 2 == 0)
                {
                    p = PlayerFactory.getPlayer(playerType[0]);

                }
                else
                {
                    p = PlayerFactory.getPlayer(playerType[1]);
                }
                p.assignWeapon(weapons[i % 2]);
                p.mission();
            }
            Console.Read();
        }
    }
}
