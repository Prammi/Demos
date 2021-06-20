using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Factory
{
    class UsiStratergy:IStratergy
    {
        public void Dispatch()
        {
            Console.WriteLine("USI Statergy");
        }
    }
}
