using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    class Details
    {
        public string FirstName { get; set; }
        public string greeting(string name)
        {
            return "hello " + name;
        }
    }

    class Student: Details //inheritance
    {
        public string studentid { get; set; }
    }

}
