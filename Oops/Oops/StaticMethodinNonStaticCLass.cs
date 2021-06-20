using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public class StopWatch
    {
        public static int counter=0;
        public StopWatch()
        {
            counter = counter + 1;
        }

        public static void TakesParams(int a, int b)
        {

        }
        public static void TakesParams()
        {

        }
    }

    public class StaticClasswithConstructor
    {
        public StaticClasswithConstructor()
        {

        }

        static StaticClasswithConstructor()
        {

        }

        public static void SomeStaticMethod()
        {

        }

        public  void SomeInstanceMethod()
        {

        }
    }
}
