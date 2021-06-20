using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {


            //Advantages 
            //    1) Singleton can implment interfaces
            //    2) Singleton instance cna be passed as a variable
            //    3) THread Safe
            //    4)Lazy Loading
            //    5)is called only when the instance is acccessed.

            //    Users 
            //    1)Loggin
            //    2)cacing
            //    3)db conns

            IEnumerable<string> obj = Singleton.getCountries();

            Singleton2 instance = Singleton2.getInstance;
            var _List = instance.getCountries();
            instance.InterFaceMethod();//interface method
            TempClass _temp = new TempClass();
            _temp.SomeMethod(instance); // instance of Single temp can be passed.


        }

       
    }

    public class TempClass
    {
        public void SomeMethod(Singleton2 instance)
        {
            Console.WriteLine("do Nothing");
        }

        //Static Types Cannot be used a Parameter.
        //public void Somemethod2(TempClass2 tempClass)
        //{

        //}
    }

    public static class TempClass2  //: iSomeInterface Static Classes cannot implement interfaces
    {
        public static void SomeMethod(Singleton2 instance)
        {
            Console.WriteLine("do Nothing");
        }
    }

    public interface iSomeInterface
    {
        void InterFaceMethod();
    }
}
