using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCloseAndLiskov
{
    class AbsSquare : Area
    {
        public double Height { get; set; }
        public  void ShapreArea()
        {
            Console.WriteLine(Height*Height);
        }
    }
}
