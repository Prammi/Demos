using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class Terrorist : IPlayer
    {
        string weapon;
        string Task;

        public void assignWeapon(string weapon)
        {
            this.weapon = weapon;
        }

        public Terrorist()
        {
            Task = "SET BOMB";
        }
        public void mission()
        {
            Console.WriteLine("Task is " +Task + "Weapon is "+ weapon);
        }
    }
}
