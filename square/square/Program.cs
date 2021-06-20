using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square
{
    class Program
    { 

        class Dimenssion
        {
            public int height { get; set; }
            public int size { get; set; }

            public Dimenssion(int _height, int _size)
            {
                this.height = _height;
                this.size = _size;
            }

        }
        static void Main(string[] args)
        {
            int numofTestCases = Convert.ToInt32(Console.ReadLine());
            if (numofTestCases >= 1 && numofTestCases <= 200)
            {
                List<Dimenssion> obj = new List<Dimenssion>();

                for (int c = 0; c < numofTestCases; c++)
                {
                    string[] tokens = Console.ReadLine().Split();
                    int a = int.Parse(tokens[0]);
                    int b = int.Parse(tokens[1]);
                    if ((a >= 1 && a <= 20) && (b >= 1 && b <= 20))
                    {
                        obj.Add(new Dimenssion(b, a));
                    }
                }
                foreach (var l in obj)
                {
                    printPyramid(l.size, l.height);
                }
                Console.Read();
            }
        }

        private static void printPyramid(int l, int h)
        {
         
            for( int i=0;i < h; i++)
            {
                int m = 0;
                while (m < (l + 1))
                {
                    for (int j = 0; j < (((h - 1) * (l + 1)) - ((l + 1) * i)); j++)
                    {
                        Console.Write("  ");
                    }
                    for(int k = 0; k <= i; k++)
                    {
                        for(int mm = 0; mm < l + 1; mm++)
                        {
                            if (m == 0 || m == l  || mm == 0 || mm == l )
                            {
                                Console.Write("* ");
                            }
                            else
                            {
                                Console.Write("  ");
                            }
                        }
                        for (int mm = 0; mm < l + 1; mm++)
                        {
                            Console.Write("  ");
                        }
                    }
                    m = m + 1;
                    Console.WriteLine();
                }
               
            }         

        }        
    }
}
