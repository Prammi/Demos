using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            AlertStateContext stateContext = new AlertStateContext();
            stateContext.alert();
            stateContext.setState(new Silent());
            stateContext.alert();
            Console.Read();


        }
    }
}
