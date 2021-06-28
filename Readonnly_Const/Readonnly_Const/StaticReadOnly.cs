using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readonnly_Const
{
   public class StaticReadOnly
    {
        public readonly static string sro1; //no error thrown
        public readonly static string sro2 ="Default value set";

        static StaticReadOnly()
        {
            //can be initialized only in static ctor and can be initializedo only once
            sro1 = sro2;// initiaized
            sro2 = "Reinitialiazation";
        }
        public StaticReadOnly()
        {
            //sro1 = ""; throws error 
            //sro2 = "";
        }

        public StaticReadOnly( int i)
        {
            //sro1 = ""; throws error 
            //sro2 = "";
        }

    }
}
