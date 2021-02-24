using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
   public class NoCashState :IATMState
    {
        private ATMMachine machine;
        public NoCashState(ATMMachine machine)
        {
            this.machine = machine;
        }

        public void EnterPincode(int pinCode)
        {
            Console.WriteLine("There is no cash in the atm machine");
        }

        public void InsertCard()
        {
            Console.WriteLine("There is no cash in the atm machine");
        }

        public void RejectCard()
        {
            Console.WriteLine("There is no cash in the atm machine");           
        }

        public void WithdrawCash(int cash)
        {
            Console.WriteLine("There is no cash in the atm machine");
            RejectCard();
           
        }
    }
}
