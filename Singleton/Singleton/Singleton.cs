using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    sealed class Singleton
    {

        private Singleton()
        {

        }
        public static List<string> _countrys = null;
        public static IEnumerable<string> getCountries()
        {
            lock (_countrys)
            {
                //lazy loaded
                if (_countrys == null)
                {
                    _countrys = new List<string>();
                }
            }
            return _countrys;
        }
    }


}
