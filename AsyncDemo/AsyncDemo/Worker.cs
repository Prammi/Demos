using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDemo
{
    class Worker
    {
        public bool iscompleted = false;
        public async void dowork()
        {
            Console.WriteLine("Work did start\n");
            await Worker2Methods();
            Console.WriteLine("Work started in Worker Class\n");
            await DoLongWork();
            Console.WriteLine("Work ended in Worker Class\n");
            iscompleted = true;
        }

        private Task Worker2Methods()
        {
            return Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Starting in Wroker2Method Class\n");
                var worker = new Worker2();
                worker.dowork();
                while (!worker.iscompleted)
                {
                    Console.Write("**\n");
                    Thread.Sleep(400);
                }
                Console.WriteLine("Ending in Wroker2Method Class\n");
            });
                
        }

        private Task DoLongWork()
        {
            return Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Long Work started \n");
                Thread.Sleep(600);
                Console.WriteLine("Long Work Ended \n");
            });


        }

    }
}
