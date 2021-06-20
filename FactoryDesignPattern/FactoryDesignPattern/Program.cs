using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory obj = new ShapeFactory();
            var xyz = obj.ReturnShape(1);
            xyz.Draw();
            var xyzs = obj.ReturnShape(2);
            xyzs.Draw();
            Console.Read();
        }
    }
}
