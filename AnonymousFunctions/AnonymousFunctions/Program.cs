using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousFunctions
{
    class Program
    {
        delegate int _AddDelegate(int a, int b);

        static void Main(string[] args)
        {
            _AddDelegate obj = delegate (int a, int b)
            {
                return a + b;
            };

            string z = obj.Invoke(2, 2).ToString();
            Console.WriteLine(z);
            Console.Read();
        }

        static int Add(int a, int b)
        {
            return a + b;

        }
    }
}
