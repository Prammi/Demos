using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPatter
{
    class Adaptee
    {

        public List<string> EmployeeListfromAdaptee()
        {
            return new List<string> { "aaa", "ddd", "fff", "ggg" };
        }
    }
}
