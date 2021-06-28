using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readonnly_Const
{
    class Readonly
    {
        public readonly string ro;

        public Readonly()
        {
            ro = "initialized from ctor";
        }

        public Readonly(string value)
        {
            ro = "reinitialized from parameterized ctor";
        }

    }
}
