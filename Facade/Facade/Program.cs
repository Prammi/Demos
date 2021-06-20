using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            GoldPriceProxy gp = new GoldPriceProxy();
            gp.getGoldFromProxy(true);
            Console.Read();
        }
    }
}
