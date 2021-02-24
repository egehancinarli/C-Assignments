using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class ATMMachine
    {
        private int amountInMachine;
        private IATMState cardPresent;
        private IATMState correctPinCode;
        private IATMState noCash;
        private IATMState noCard;

        //Current state of the machine.
        private IATMState machineState;
        public ATMMachine(int amountInMachine)
        {
            cardPresent = new CardPresentState(this);
            correctPinCode = new CorrectPinState(this);
            noCash = new NoCashState(this);
            noCard = new NoCardState(this);

            this.amountInMachine = amountInMachine;

            if (AmountInMachine > 0)
                machineState = noCard; //if machine has cash then it's ready to use and user can insert card.
            else
                machineState = noCash; //Machine has no cash that's why I change the state to noCash.
        }
        public int AmountInMachine
        {
            get
            {
                return amountInMachine;
            }
        }
        public void SetMachineState(IATMState state)
        {
            machineState = state;
        }
        public void setAmountInMachine(int amount)
        {
            amountInMachine = amount;
        }

        public void EnterPincode(int pinCode)
        {
            machineState.EnterPincode(pinCode);
        }
        public void InsertCard()
        {
            machineState.InsertCard();
        }

        public void RejectCard()
        {
            machineState.RejectCard();
        }
        public void WithdrawCash(int cash)
        {
            machineState.WithdrawCash(cash);
        }
        

        public IATMState GetCardPresentState()
        {
            return cardPresent;
        }
        public IATMState GetCorrecPinState()
        {
            return correctPinCode;
        }
        public IATMState GetNoCardState()
        {
            return noCard;
        }

        public IATMState GetNoCashState()
        {
            return noCash;
        }
      
    }
}
