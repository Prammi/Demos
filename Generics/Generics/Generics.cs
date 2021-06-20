using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Generics<T>
    {
        public  T SomeProp { get; set; }
        public Generics(T gen)
        {
            SomeProp = gen;
        }

        public T ReturnDataValue()
        {
            return SomeProp;
        }

        public T ModifyData<T>(T input)
        {
            return input;
        }
    }
}
