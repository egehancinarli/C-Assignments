using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class CardPresentState : IATMState
    {
        private ATMMachine machine;
        public CardPresentState(ATMMachine machine)
        {
            this.machine = machine;
        }
        public void EnterPincode(int pinCode)
        {
            //this is hardcoded for now because i wasnt sure if this needed validation
            if(pinCode==1234)
            {
                Console.WriteLine("You have entered the correct pin code.");
                machine.SetMachineState(machine.GetCorrecPinState());
            }
            else
            {
                RejectCard();
            }

        }

        public void InsertCard()
        {
            Console.WriteLine("You have already inserted a card!!");
        }

        public void RejectCard()
        {
             Console.WriteLine("Your card has been rejected.");
            machine.SetMachineState(machine.GetNoCardState());// Do i need to set the machine to something here too ?
        }

        public void WithdrawCash(int cash)
        {
            Console.WriteLine("Please enter your pin code first!!");
        }
    }
}
