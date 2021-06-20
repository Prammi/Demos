using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    interface IEnemyShipFactory
    {
        EnemyShip makeEnemyShip(string s);
    }
}
