using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public class OperatorOl_Poly
    {
    





    }

    internal class Box
    {
        public int lenght { get; set; }
        public int breadth { get; set; }

        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.lenght = b.lenght + c.lenght;
            box.breadth = b.breadth + c.breadth;
            return box;
        }
    }
}
