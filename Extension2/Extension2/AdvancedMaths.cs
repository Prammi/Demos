using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tranform.Try;

namespace Extension2
{
    public static class AdvancedMaths
    {
        public static string DivideBy(this Calculator calc, int number=100)
        {
            return "= " + (number / 10).ToString();
        }
    }
}
