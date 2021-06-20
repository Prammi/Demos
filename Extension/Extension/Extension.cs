using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    public static class Extension
    {
        public static bool ExtensionMethod(this int i,int value)
        {
            return i > value;
        }
    }
}
