using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncandTask
{
    public class Worker
    {

        public bool IsComplete { get; private set; }
        public async void DoWork()
        {
            Console.WriteLine("Do Work Started");
            IsComplete = false;
            await LongOperation();
            IsComplete = true;
            Console.WriteLine();
            Console.WriteLine("Do Work Ended");
        }

        private Task LongOperation()
        {
            return Task.Factory.StartNew(() => { Thread.Sleep(5000); });
        }
    }
}