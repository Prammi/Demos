using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Factory
{
    interface IFactory
    {
        IStratergy getStratergyFromFactory(int a);
    }
}
