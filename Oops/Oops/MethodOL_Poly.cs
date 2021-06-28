using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    class MethodOL_Poly
    {
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public int Add(int a, int b)
        {
            return a + b;
        }

        //different return types are not considers to be overloading    
        //public string Add(int a, int b)
        //{
        //    return (a + b).ToString();
        //}

        //even optional parameters  are not considers to be overloading    
        //public int Add(int a, int b= 10)
        //{
        //    return a + b;
        //}

    }
}
