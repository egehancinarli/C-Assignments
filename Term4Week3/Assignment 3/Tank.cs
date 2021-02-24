using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Tank : IAttacker
    {
        private  Random generator;
        public Tank()
        {
            generator = new Random();
        }
        public void AssignDriver(string name)
        {
            Console.WriteLine("{0} is steering the tank",name);
        }

        public void DriveForward()
        {
            Console.WriteLine("Tank moves {0} positions forward", generator.Next(1,9));
        }

        public void UseWeapon()
        {
            Console.WriteLine("Tank causes Damage");
        }
    }
}
