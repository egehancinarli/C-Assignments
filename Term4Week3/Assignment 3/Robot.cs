using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Robot
    {
        private Random generator;
        public Robot()
        {

            generator = new Random();
        }
        public void BashWithHands()
        {
            Console.WriteLine("Robot causes damage with hands");
        }
        public void MoveByPerson(string name)
        {
            Console.WriteLine("Robot is moved by {0}",name);
        }
        public void WalkForward()
        {
            Console.WriteLine("Robot walks {0} steps forward",generator.Next(1,9));
        }
    }
}
