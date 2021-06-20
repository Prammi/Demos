using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        delegate void Operation(int number);
        //LINQ
        //DELEGAATES
        //EVENTS 
        static void Main(string[] args)
        {
            //firstExample();
            //SecondExampleWithList();
            //DelegatesExample();
            TaskParallelLibray();
            Console.Read();

        }

        private static void TaskParallelLibray()
        {
            var intergers = new List<int> { 1, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Parallel.ForEach(intergers, (i) => Console.WriteLine(i));
            Parallel.For(1, 100, (i) => Console.WriteLine(i));
            //this paralle also waits till all those taks are completed ... i mean writing integeres and then it will continue..
            //.. ..in norma it is thread blocking or built in task.wait all 

            //=======================

            var t1 = new Task(() => doSomeWork(1, 3000));
            var t2 = new Task(() => doSomeWork(2, 2000));
            var t3 = new Task(() => doSomeWork(2, 1000));
            t1.Start();
            t2.Start();
            t3.Start();

            var taskList = new List<Task> { t1, t2, t3 };
            Task.WaitAll(taskList.ToArray());//will prevent below steps from happening untill all taks are completed

            Console.WriteLine("Press any key to quit");
            Console.Read();

        }

        private static void doSomeWork(int v1, int v2)
        {
            Console.WriteLine("Task {0} has began", v1);
            Thread.Sleep(v2);
            Console.WriteLine("Task {0} has Completed", v1);

        }

        private static void SecondExampleWithList()
        {
            var people = new List<Person>
            {
                new Person{FirstName="Pramod",LastName="Gama",Age=25},
                new Person { FirstName = "Sumanth", LastName = "Gama", Age = 25 },
                new Person { FirstName = "Usha", LastName = "Gama", Age = 25 },
                new Person { FirstName = "Alpha", LastName = "Soman", Age = 25 },
                new Person { FirstName = "Beta", LastName = "Soman", Age = 25 }
            };

            var result = from p in people
                         orderby p.LastName descending
                         group p by p.LastName;
            foreach (var item in result)
            {
                Console.WriteLine(item.Key + "   " + item.Count());
                foreach (var p in item)
                {
                    Console.WriteLine("\t{0},{1}", p.LastName, p.FirstName);
                }
            }

        }


        private static void firstExample()
        {
            string _stringSample = "Pramod is a good person";
            var result = from c in _stringSample
                         select c;
            Console.WriteLine("Example with out Group by");
            foreach (var c in result)
            {
                Console.WriteLine("The character is " + c);
            }
            Console.WriteLine("");
            Console.WriteLine("Example with  filters");
            var result2 = from c in _stringSample
                          where (c == 'a' || c == 'e' || c == '1' || c == 'o' || c == 'u')
                          select c;

            foreach (var c in result2)
            {
                Console.WriteLine("The character is " + c); ;
            }
            Console.WriteLine("");
            Console.WriteLine("Example with  group by");
            var result3 = from c in _stringSample
                          where (c == 'a' || c == 'e' || c == '1' || c == 'o' || c == 'u')
                          group c by c;

            foreach (var c in result3)
            {
                Console.WriteLine("The key is " + c.Key + "the count is" + c.Count());
            }

        }



        private static void DelegatesExample()
        {
            Operation op = Double;
            Operation op2 = Triple;
            op.Invoke(2);//one type of calling 
            op2(1);//second type of calling 



            //another way of callign it without proving additional definition separately.
            Operation op3 = delegate (int n)
            {
                Console.WriteLine("\nNumber is {0} , Double is {1}", n, n * 2);
            };


            //another way of callign using Lambada
            Operation op4 = n => { Console.WriteLine("\nNumber is {0} , Double is {1}", n, n * 2); };

            //passing method as parameter with values;
            ExecuteOperation(1, op);
            ExecuteOperation(1, op2);

            //or
            //chanining the delegates
            op = op + Triple;
            ExecuteOperation(9, op);


        }

        static void Double(int n)
        {
            Console.WriteLine("\nNumber is {0} , Double is {1}", n, n * 2);
        }
        static void Triple(int n)
        {
            Console.WriteLine("\nNumber is {0} , Double is {1}", n, n * 3);
        }
        static void ExecuteOperation(int n, Operation op)
        {
            op(n);
        }
    }
}
