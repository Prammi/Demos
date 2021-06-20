using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton2 :iSomeInterface //Singleton classes can implement interfaces.
    {
        private static volatile Singleton2 instance;
        private static object syncRoot = new Object();
        private Singleton2()
        {

        }
        public static Singleton2 getInstance   {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton2();
                        }
                    }
                }
                return instance;
            }

        }

        public  List<string> getCountries()
        {
            return new List<string>();
        }

        public void InterFaceMethod()
        {
            Console.WriteLine("do nothing ");
        }
    }
}
