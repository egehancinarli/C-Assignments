using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class dice
    {
        public int value;
        private Random rnd;

        public dice(Random rnd)
        {
           
            this.rnd = rnd;
        }
        public void Throw()
        {

            value = rnd.Next(1, 7);
        }
        public void DisplayValue()
        {
            Console.Write("  " + value);
        }
    }
}
