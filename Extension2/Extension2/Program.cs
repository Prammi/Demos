using MathsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tranform.Try;

namespace Extension2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Add(1, 2); //using dll methods
          string i =  calculator.DivideBy(200); // Extension Method
            Console.WriteLine(i);
            Console.Read();

        }
    }
}
