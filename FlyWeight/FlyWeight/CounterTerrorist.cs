using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class CounterTerrorist:IPlayer
    {
        string weapon;
        string Task;

        public void assignWeapon(string weapon)
        {
            this.weapon = weapon;
        }

        public CounterTerrorist()
        {
            Task = "Diffuse BOMB";
        }
        public void mission()
        {
            Console.WriteLine("Task is " + Task + "Weapon is " + weapon);
        }
    }
}
