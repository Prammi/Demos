using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPatter
{
    class Program
    {
        static void Main(string[] args)
        {
            IAdapter adapter = new Adapter();
            Client client = new Client(adapter);
            var employees = client.getEmployeefromClient();
            int i = 10;
        }
    }
}
