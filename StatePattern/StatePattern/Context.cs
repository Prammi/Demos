using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Context

    {
        private States _States;

        // Constructor

        public Context(States States)
        {
            this.States = States;
        }

        // Gets or sets the States

        public States States
        {
            get { return _States; }
            set

            {
                _States = value;
                Console.WriteLine("States: " +
                  _States.GetType().Name);
            }
        }

        public void Request()
        {
            _States.Handle(this);
        }
    }
}
