using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDesignPattern
{
    class NokiaPixel : ISmartPhone
    {
        public void GetModelDetail()
        {
            Console.WriteLine("Nokia -SmartPhone");
        }
    }
}
