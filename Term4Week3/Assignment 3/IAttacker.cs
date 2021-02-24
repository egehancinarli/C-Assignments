using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    interface IAttacker
    {
        void AssignDriver(string name); // ASK ABOUT THIS AND GENERATOR + CONWAY RESET CHANGE BUTTONS
        void DriveForward();
        void UseWeapon();
    }
}
