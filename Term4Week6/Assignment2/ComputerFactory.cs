using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public abstract class ComputerFactory
    {
        public abstract IMonitor CreateMonitor();
        public abstract IProcessor CreateProcessor();
        public abstract IHardDisk CreateHardDisk();
    }
}
