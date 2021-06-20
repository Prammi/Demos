using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Factory
{
    class StratergyContext
    {
        IStratergy _stratergy;
        public StratergyContext(IStratergy stratergy)
        {
            _stratergy = stratergy;
        }

        public void SendNotification()
        {
            _stratergy.Dispatch();
        }
    }
}
