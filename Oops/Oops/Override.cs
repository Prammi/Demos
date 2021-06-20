using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    class Override
    {

        public virtual void Show()
        {
            Console.WriteLine("Hello : Base class");
        }
    }

    class Override_child : Override
    {

        public override void Show()
        {
           //override is for overiding the virtual method in the base calss .. virtual is mandatory 
            Console.WriteLine("Hello : Child class");
        }
    }


    class Override_child2 : Override_child
    {

        public override void Show()
        {
            //override is for overiding the virtual method in the base calss .. if the base calss ie if the override_child is sealed than this will throw error 
            Console.WriteLine("Hello : Child class 2");
        }
    }
}
