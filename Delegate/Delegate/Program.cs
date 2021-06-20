using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    delegate int OperationDelegate(int param1, int param2);
    delegate bool FunctionDelegate(int i);

    class Program
    {

        class MyList
        {
            List<int> listnumbers = new List<int>();
            public MyList()
            {
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 111, 1112, 1111, 2222, 2222, 3333, 444, 444 };
                listnumbers.AddRange(numbers);
            }

            public List<int> findNumber(FunctionDelegate f)
            {
                var results = new List<int>();
                foreach (var item in listnumbers)
                {
                    if (f(item) == true)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }
        }
        
        static int Add(int a,int b)
        {
         
            return a + b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
         
            OperationDelegate _add = Add;

            //anonymous method
            OperationDelegate _mul = delegate (int a, int b)
            {
               
                return a * b;
            };
            

            int result1 = _add(1, 2);
            int resul2t = _mul(1, 2);


            var results = new MyList();
            var tempResults = results.findNumber(x => x < 100);

        }
    }
}
