using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            IMobileClient nokiaMobilePhone = new Nokia();
            MobileAbsFactory nokiaClient = new MobileAbsFactory(nokiaMobilePhone);

            Console.WriteLine("********* NOKIA **********");
            nokiaClient.GetSmartPhoneModelDetails();
           nokiaClient.GetNormalPhoneModelDetails();
        }
    }
}
