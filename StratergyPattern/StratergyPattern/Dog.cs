using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratergyPattern
{
    class Dog:Animal
    {
        public Dog()
        {
            Name = "Dog";
            FlyingProperty = new cantFly();
        }
    }
}
