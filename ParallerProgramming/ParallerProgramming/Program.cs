using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallerProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Task 1 - iteration {0}", i);
                    Task.Delay(1000);
                }
                Console.WriteLine("Task 1 complete");
            });
            Task task2 = new Task(() =>
            {
                Console.WriteLine("Task 2 complete");
            });
            task1.Start();
            task2.Start();
            Console.WriteLine("Waiting for tasks to complete.");
            //Task.WhenAll(task1, task2);
            Task.WaitAll(task1, task2);
            Console.WriteLine("Tasks Completed.");


            ADDNumbers(10, 20, new int[] { 30, 40, 50 });

            //Degree of parallelism

            //run the below method by commenting and uncommneting the paralleloption and see the diff
            var options = new ParallelOptions()
            {
                MaxDegreeOfParallelism = 2
            };


            List<int> integerList = Enumerable.Range(0, 10).ToList();
            Parallel.ForEach(integerList, i =>
            {
                Console.WriteLine(@"value of i = {0}, thread = {1}",
                    i, Thread.CurrentThread.ManagedThreadId);
            });

            Console.WriteLine("Press any key to exist");
            Console.ReadLine();
        }

        private static void ADDNumbers(int FN, int SN, int[] restOfTheNumbers)
        {
            int result = FN + SN;
            // loop thru restOfTheNumbers only if it is not null otherwise 
            // you will get a null reference exception
            if (restOfTheNumbers != null)
            {
                foreach (int i in restOfTheNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Total = " + result.ToString());
        }
    }
}
