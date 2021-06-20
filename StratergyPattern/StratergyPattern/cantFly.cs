using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratergyPattern
{
    class cantFly : IFly
    {
        public string Flys()
        {
            return "Cant Fly";
        }
    }
}
