using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPatter
{
    class Client
    {

        IAdapter adapter;
        public Client(IAdapter _adapter)
        {
            adapter = _adapter;
        }

        public List<string> getEmployeefromClient()
        {
            return adapter.GetEmployeefromAdapter();
        }
    }
}
