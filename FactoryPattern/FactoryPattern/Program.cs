using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        //Allows you to create objects without specifying the exact class of object that will be created.
        static void Main(string[] args)
        {
            IEnemyShipFactory factory = new EnemyShipFactory();
            EnemyShip BattleShip = factory.makeEnemyShip("B");
            BattleShip.setname("Hello Battle Ship");
            BattleShip.getName();
            Console.WriteLine(BattleShip.getName());
            Console.Read();
        }
    }
}
