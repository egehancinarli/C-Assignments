using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Term4Week6
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
            ComputerShop highShop = new HighBudgetShop();
            highShop.Assemble();
            Console.WriteLine();
            Console.WriteLine("[shop creating cheap computers]");
            ComputerShop lowShop = new LowBudgetShop();
            lowShop.Assemble();
            
        }
    }
}
