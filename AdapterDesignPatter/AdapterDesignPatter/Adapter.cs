using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPatter
{
    class Adapter : Adaptee, IAdapter
    {
        public List<string> GetEmployeefromAdapter()
        {
            return EmployeeListfromAdaptee();
        }
    }
}
