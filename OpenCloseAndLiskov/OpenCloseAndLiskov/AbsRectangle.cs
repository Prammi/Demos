using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCloseAndLiskov
{
    class AbsRectangle : Area
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public void SetHeight(int height)
        {
            Height = height;
        }
        public  void ShapreArea()
        {
            Console.WriteLine(Width*Height);
        }
    }
}
