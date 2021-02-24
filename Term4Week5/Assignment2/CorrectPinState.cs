using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class CorrectPinState:IATMState
    {
        private ATMMachine machine;
        public CorrectPinState(ATMMachine machine)
        {
            this.machine = machine;
        }

        public void EnterPincode(int pinCode)
        {
            Console.WriteLine("You have already entered the correct pin code.");
        }

        public void InsertCard()
        {
            Console.WriteLine("You have already inserted a card.");
        }

        public void RejectCard()
        {
            Console.WriteLine("Your card has ben rejected.");
            machine.SetMachineState(machine.GetNoCardState());
        }

        public void WithdrawCash(int cash)
        {
            if (machine.AmountInMachine >= cash)
            {
                Console.WriteLine("{0} is withdrawn from the machine",cash);
                machine.setAmountInMachine(machine.AmountInMachine-cash);
                RejectCard();
                if (machine.AmountInMachine == 0)
                    machine.SetMachineState(machine.GetNoCashState());             
                // Am i missing anything here ?
            }              
            else
            {
                Console.WriteLine("Not enough cash available in the machine");
                RejectCard(); 
            }
               
        }
    }
}
