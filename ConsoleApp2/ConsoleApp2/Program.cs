using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibs = new int[7];
            for( int i=0; i <7; i++)
            {
               if( i==0 || i == 1)
                {
                    fibs[i] = i;
                }
               else
                {
                    fibs[i] = fibs[i - 1] + fibs[i - 2];

                }
                Console.WriteLine(fibs[i]);
                
            }
            Console.Read();

        }

        //public static int fib( int n)
        //{
        //    if( n==0 )
        //    {
        //        return 0;
        //    }
        //    if (n == 1)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        return n;
                
        //    }
        //}
    }
}
