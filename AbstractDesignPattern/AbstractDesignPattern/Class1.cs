using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDesignPattern
{
    class Samsungguru : INormalPhone
    {
        public void GetModelDetail()
        {
            Console.WriteLine("Samsing -Normal Phone");
        }
    }
}
