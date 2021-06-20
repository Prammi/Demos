using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            int geo = 1;
            StratergyContext ctx = new StratergyContext(new StatergyFactory().getStratergyFromFactory(geo));
            ctx.SendNotification();
            Console.Read();
        }
    }
}
