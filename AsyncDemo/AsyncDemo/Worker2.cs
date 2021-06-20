using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDemo
{
    class Worker2
    {
        public bool iscompleted = false;
        public async void dowork()
        {
            Console.WriteLine("Work started in Worker2 Class\n");
            await DoLongWork();
            Console.WriteLine("Work ended in Worker2 Class\n");
            iscompleted = true;
        }

        private Task DoLongWork()
        {
            return Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Long Work started in worker2\n");
                Thread.Sleep(500);
                Console.WriteLine("Long Work Ended in worker2\n");
            });


        }
    }
}
