using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class RobotAdapter : IAttacker
    {
        private Robot robot;
        public RobotAdapter(Robot robot)
        {
            this.robot = robot;
        }
        public void AssignDriver(string name)
        {
            robot.MoveByPerson(name);
        }

        public void DriveForward()
        {
            robot.WalkForward();
        }

        public void UseWeapon()
        {
            robot.BashWithHands();
        }
    }
}
