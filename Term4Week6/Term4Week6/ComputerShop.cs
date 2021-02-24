using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Term4Week6
{
    public abstract class ComputerShop
    {
        public void Assemble()
        {
            IMonitor monitor = CreateMonitor();
            IProcessor processor = CreateProcessor();
            IHardDisk hardDisk = CreateHardDisk();
            processor.PerformOperation();
            hardDisk.StoreData();
            monitor.Display();
        }

        public abstract IMonitor CreateMonitor();
        public abstract IProcessor CreateProcessor();
        public abstract IHardDisk CreateHardDisk();

    }
}
