using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    class Abstraction
    {
        /// <summary>
        ///  wrapping this a single entity ; what are things create a module is abstration 
        /// </summary>
        public string ObjectId { get; set; }
        public string ObjectName { get; set; }
        public string ObjectDesc { get; set; }

        public void processOrder()
        {
            checkforPrice();
            checkforStock();
            //do someting in this method
        }

        private void checkforPrice()
        {
            //do something
        }

        private void checkforStock()
        {
            //do something

        }
    }
}
