using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static void Main(string[] args)
        {
            bool _continue = true;
           Program.CallProcess();
            Console.WriteLine("her");
            Console.Read();
        }

        public static async void CallProcess()
        {
            Console.WriteLine("CP called");
            await LongProcess();
            Console.WriteLine("CP Ended");
         

        }

        private static Task LongProcess()
        {
            int milliseconds = 3000;
            return Task.Run(() =>
            {
                Thread.Sleep(milliseconds);

            });
        }
    }


}
