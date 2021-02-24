using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public interface IATMState
    {
        void InsertCard();
        void RejectCard();
        void WithdrawCash(int cash);
        void EnterPincode(int pinCode);
    }
}
