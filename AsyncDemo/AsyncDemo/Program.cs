using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting in Main Class\n");
            var worker = new Worker();
            worker.dowork();
            while (!worker.iscompleted)
            {
                Console.WriteLine("From Main Claass . \n");
                Thread.Sleep(100);
            }
            Console.WriteLine("Ending in Main Class\n");
            Console.Read();

        }


    }
}
