using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    class Program
    {
        static void Main(string[] args)
        {

            Student obj = new Student();
            obj.greeting("pramod");


            //Abstraction and encapsulation 

            Abstraction obj2 = new Abstraction();
            obj2.processOrder(); /// this is abstraction you are showing one method here and hiding others ... we only give what is required and hide rest ...

            //PolyMorphism 

            Box _box1 = new Box();
            Box _box2 = new Box();
            _box1.lenght = 1;
            _box2.lenght = 3;
            _box1.breadth = 5;
            _box2.breadth = 10;
            Box _bpx3 = _box1 + _box2; // opearotr over loading .. method shoudl be inside the class and shoudl be static
            Console.WriteLine(_bpx3.lenght);


            //method overloading 

            MethodOL_Poly obj5 = new MethodOL_Poly();
            obj5.Add(1, 2);
            obj5.Add(1, 2, 3);

            //new Keyword

            New _newObj = new New();
            New_child _newChildObj = new New_child();
            New _newObjParent = new New_child();
            _newObj.Show(); //parent class
            _newChildObj.Show(); //child clas 
            _newObjParent.Show(); //paret class only


            //virtual Keyword
            Override _overrideObj = new Override();
            Override_child _overrideChildObj = new Override_child();
            Override _overrideObjParent = new Override_child();
            _newObj.Show(); //parent class
            _newChildObj.Show(); //child clas 
            _newObjParent.Show(); //child class only and its overrriden

            //static method in a non static class

            StopWatch _sw1 = new StopWatch();
            Console.WriteLine(StopWatch.counter); // will retunr 1 
            StopWatch _sw2 = new StopWatch();
            Console.WriteLine(StopWatch.counter); // will retunr 2
            StopWatch _sw3 = new StopWatch();
            Console.WriteLine(StopWatch.counter); // will retunr 3 

            // only once instance is created and they are being stored.

            //static methods can be overloading not overridden
            StopWatch _sw4 = new StopWatch();
            StopWatch.TakesParams(); //method overloading
            StopWatch.TakesParams(1,2);//method overloading

            //static classes with constructors
            //static constructors do not take any access specifiers

            //static const is called only once durong the life cycle and is called first before instance ctor.

            //used fro dbconn and writing logs for seeing if the class is created.
            StaticClasswithConstructor.SomeStaticMethod(); //if you are calling static method only static constructor is invoked
            StaticClasswithConstructor.SomeStaticMethod();//if you are calling again static constructor is not invoked and no constructor is invoked

            StaticClasswithConstructor _sswc = new StaticClasswithConstructor(); // this will invoce Static constructor and then instance constructor
            StaticClasswithConstructor _sswc2 = new StaticClasswithConstructor(); //only instance is invoked


        }
    }
}
