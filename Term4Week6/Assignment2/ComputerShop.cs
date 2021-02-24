using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public  class ComputerShop
    {
        public void Assemble(ComputerFactory factory)
        {
            IMonitor monitor = factory.CreateMonitor();
            IProcessor processor = factory.CreateProcessor();
            IHardDisk hardDisk = factory.CreateHardDisk();
            processor.PerformOperation();
            hardDisk.StoreData();
            monitor.Display();
        }  

    }
}
