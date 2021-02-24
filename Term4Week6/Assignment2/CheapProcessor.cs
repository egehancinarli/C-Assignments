using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class CheapProcessor : IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("Performing operation not so quickly...");
        }
    }
}
