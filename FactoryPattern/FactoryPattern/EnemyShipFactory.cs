using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class EnemyShipFactory : IEnemyShipFactory
    {
      public  EnemyShip makeEnemyShip(string s)
        {
            if (s.ToUpper() == "B")
            {
                return new BattleShip();
            }
            else if (s.ToUpper() == "U")
            {
                return new UFOShip();
            }
            return null;
        }
    }
}
