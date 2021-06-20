using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class GoldPrices : iPrice
    {
        public int GetPrice()
        {
            return 1;
        }
    }
}
