using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
            Console.ReadLine();
        }
        void Start()
        {
            Tank tank = new Tank();
            tank.AssignDriver("Frank");

            Robot robot = new Robot();
            robot.MoveByPerson("Mark");

            List<IAttacker> attackers = new List<IAttacker>();
            attackers.Add(tank);
            attackers.Add(new RobotAdapter(robot));


            foreach (IAttacker attacker in attackers)
            {
                attacker.DriveForward();
                attacker.UseWeapon();
            }
        }

    }
}
