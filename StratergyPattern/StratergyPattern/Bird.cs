﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratergyPattern
{
    class Bird:Animal
    {
        public Bird()
        {
            Name = "Bird";
            FlyingProperty = new canFly();
        }
    }
}
