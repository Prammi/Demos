using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCloseAndLiskov
{
    class Program
    {
        static void Main(string[] args)
        {

            //Liskov Failing 
            var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };
            SumCalculator sum = new SumCalculator(numbers);
            Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");
            Console.WriteLine();
            EvenNumbersSumCalculator evenSum = new EvenNumbersSumCalculator(numbers);
            Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");
            SumCalculator evenSum2 = new EvenNumbersSumCalculator(numbers);
            Console.WriteLine($"The sum of all the even numbers: {evenSum2.Calculate()}");

            //Liskov Passing 
            LiskovSumCalculator lsum = new LiskovSumCalculator(numbers);
            Console.WriteLine($"The sum of all the numbers: {lsum.Calculate()}");
            Console.WriteLine();
            LiskovEvenSumCalculator levenSum = new LiskovEvenSumCalculator(numbers);
            Console.WriteLine($"The sum of all the even numbers: {levenSum.Calculate()}");
            LiskovSumCalculator levenSum2 = new LiskovEvenSumCalculator(numbers);
            Console.WriteLine($"The sum of all the even numbers: {levenSum2.Calculate()}");


            //Open Closed

            Area _a = new AbsRectangle();
            _a.ShapreArea();
            Area _aa = new AbsSquare();
            _a.ShapreArea();
            Console.Read();
        }


    }
}
