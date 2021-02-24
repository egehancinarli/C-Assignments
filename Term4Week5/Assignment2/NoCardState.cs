using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class NoCardState : IATMState
    {
        private ATMMachine machine;
        public NoCardState(ATMMachine machine)
        {
            this.machine = machine;
        }

        public void EnterPincode(int pinCode)
        {
            Console.WriteLine("Please insert a card first.");
        }

        public void InsertCard()
        {
            Console.WriteLine("Please enter a pin code");
            machine.SetMachineState(machine.GetCardPresentState());
        }

        public void RejectCard()
        {
            Console.WriteLine("There is no card to reject");
        }

        public void WithdrawCash(int cash)
        {
            Console.WriteLine("Please insert a card and enter your pin code first.");
        }
    }
}
