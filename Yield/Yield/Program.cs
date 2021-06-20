using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yield
{
    class Program
    {
        static List<int> _intList = new List<int>();
        static void Main(string[] args)
        {
            Program obj = new Program();

            FillValues();
            foreach (int i in Filter())
            {
                Console.WriteLine(i);
            }


        }
        static IEnumerable<int> Filter()
        {
            foreach (int i in _intList)
            {
                if (i > 3)
                {
                    yield return i;
                }
            }
        }
        public static void FillValues()
        {
            _intList.Add(1);
            _intList.Add(2);
            _intList.Add(3);
            _intList.Add(4);
            _intList.Add(6);
        }
    }
}
