using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Factory
{
    class StatergyFactory : IFactory
    {
        public IStratergy getStratergyFromFactory(int a)
        {
            if (a == 1)
            {
                return new UsStratergy();
            }
            else
            {
                return new UsiStratergy();

            }
        }
    }
}
