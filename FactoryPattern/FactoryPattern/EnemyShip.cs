using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class EnemyShip
    {
        public string name;

        public void setname(string name)
        {
            this.name = name;
        }
        public string getName() { return name; }
    }
}
