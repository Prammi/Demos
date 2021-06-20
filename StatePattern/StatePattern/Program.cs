using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account account = new Account("Jim Johnson");

            //// Apply financial transactions

            //account.Deposit(500.0);
            //account.Deposit(300.0);
            //account.Deposit(550.0);
            //account.PayInterest();
            //account.Withdraw(2000.00);
            //account.Withdraw(1100.00);


            Context c = new Context(new ConcreteStateA());

            // Issue requests, which toggles state

            c.Request();
            c.Request();
            c.Request();
            c.Request();

            // Wait for user

            Console.ReadKey();


            // Wait for user

            Console.ReadKey();
        }
    }
}
