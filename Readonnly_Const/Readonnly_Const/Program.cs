using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readonnly_Const
{
    class Program
    {
        public const int myvar = 10;
        public const string str = "GeeksforGeeks";
        public readonly int myvar1;
        public readonly int myvar2;


      

        static void Main(string[] args)
        {

            PrivateSetter obj = new PrivateSetter();
          //  obj.Name = "Pramod"; // this will cause an error coz the setter is set to private;
                                 // hence we cannot set the value and use it only as readonly
            string _name = obj.Name;
            Console.WriteLine(_name);

            PrivateSetter obj1 = new PrivateSetter();
            obj1.changeName();
            string _name2 = obj1.Name;
            Console.WriteLine(_name2);



            //Readonly classic

            Readonly _ro = new Readonly();
            Readonly _ro2 = new Readonly("Parameterized ctor");

            Console.WriteLine(_ro.ro);
            Console.WriteLine(_ro2.ro);

            //Static Readonly


            Console.WriteLine(StaticReadOnly.sro1);
            Console.WriteLine(StaticReadOnly.sro2);


            Console.Read();

        }

        public Program()
        {
            myvar1 = 1;
            myvar2 = 2;
        }
        public void someOtherClass()
        {
          //read onlyu cannot be declared out side ctor and setter type 
        }

    }
}
