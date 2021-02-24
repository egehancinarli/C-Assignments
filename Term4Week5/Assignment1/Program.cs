using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
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
            Logger uniqueInstance = Logger.GetInstance();
            MainSystem system = new MainSystem();

            uniqueInstance.Log("main","starting");
            system.DoSomeMainWork();
            uniqueInstance.Log("main", "finishing");
        }
    }
}
