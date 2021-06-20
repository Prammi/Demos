using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    class New
    {

       public void Show()
        {
            Console.WriteLine("Hello : Base class");
        }
    }

    class New_child : New
    {

        public new  void Show()
        {
            //new key word is for method hididng ... no error but it will hide the method 
            Console.WriteLine("Hello : Child class");
        }
    }


}
