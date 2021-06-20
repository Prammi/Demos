using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Generics<int> obj = new Generics<int>(10);
            int a = obj.ReturnDataValue();
            int returndValue = obj.ModifyData(10);

            Generics<char> obj1 = new Generics<char>('a');
            char aa = obj1.ReturnDataValue();
            char returndValue2 = obj.ModifyData('a');
        }
    }
}
;