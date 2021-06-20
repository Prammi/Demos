using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class ShapeFactory
    {

        public Ishape ReturnShape(int i)
        {
            Ishape _ishape = null;
            if (i == 1)
            {
                _ishape= new Rectangle();
            }

            if (i != 1)
            {
                _ishape= new Square();
            }
            return _ishape;
        }
    }
}
