using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class GoldPriceProxy
    {
        iPrice _iPrice;
        public Int32 getGoldFromProxy(bool getpric)
        {
            if (getpric)
            {
                return  (new GoldPrices()).GetPrice();
            }
            else
            {
                return 0;
            }
            
        }
    }
}
