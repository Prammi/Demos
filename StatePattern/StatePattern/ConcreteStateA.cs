using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class ConcreteStateA : States

    {
        public override void Handle(Context context)
        {
            context.States = new ConcreteStateB();
        }
    }
}
