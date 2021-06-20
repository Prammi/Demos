using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDesignPattern
{
    class SamsungGalaxy : ISmartPhone
    {
        public void GetModelDetail()
        {
            Console.WriteLine("Samsung- smart phone");
        }
    }
}
