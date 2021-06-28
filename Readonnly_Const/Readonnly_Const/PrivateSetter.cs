using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readonnly_Const
{
    class PrivateSetter
    {

        private static int  increment =10;
        private string _name = "Name";
        public string Name
        {
            get { return _name; }
            private set
            {
              
            }
        }

        public void changeName()
        {
            _name = _name + increment;
            increment++;

        }
    }
}
