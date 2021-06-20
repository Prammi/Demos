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


            REctangle r = Program.getNewRectangle();

            r.setWidth(5);
            r.setHeight(10);
            // user knows that r it's a rectangle. 
            // It assumes that he's able to set the width and height as for the base class

            Console.WriteLine(r.getArea());
            // now he's surprised to see that the area is 100 instead of 50.

            //Open Closed

            Area _a = new AbsRectangle();
            _a.ShapreArea();
            Area _aa = new AbsSquare();
            _a.ShapreArea();



        }

        private static REctangle getNewRectangle()
        {
            // it can be an object returned by some factory ... 
            return new Square();
        }
    }
}
