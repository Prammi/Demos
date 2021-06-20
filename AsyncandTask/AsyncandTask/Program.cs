using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncandTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting");
            var worker = new Worker();
            worker.DoWork();
            Console.WriteLine("Main thread broken");
            while (!worker.IsComplete)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }
            Console.WriteLine("Done");
            Console.Read();

        }


    }
}
