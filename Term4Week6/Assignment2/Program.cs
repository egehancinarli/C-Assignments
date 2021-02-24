using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
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
            Console.WriteLine("[shop creating expensive computers]");
            ComputerFactory highBudgetFactory = new HighBudgetFactory();
            ComputerShop highShop = new ComputerShop();
            highShop.Assemble(highBudgetFactory);
            Console.WriteLine();
            Console.WriteLine("[shop creating cheap computers]");
            ComputerFactory lowBudgetFactory = new LowBudgetFactory();
            ComputerShop lowShop = new ComputerShop();                                              
            lowShop.Assemble(lowBudgetFactory);

            // I created a second shop for low budget factory because it was indicated in the assignment to do so.

        }
    }
}
