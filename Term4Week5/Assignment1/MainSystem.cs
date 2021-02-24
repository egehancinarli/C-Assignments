using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class MainSystem
    {
        private Logger loggerinstance;
        private SubSystem subSystem;
        public MainSystem()
        {
            loggerinstance = Logger.GetInstance();
            subSystem = new SubSystem();
        }
        public void DoSomeMainWork()
        {
            loggerinstance.Log("MainSystem","Doing some main work");
            subSystem.DoSomeWork();
            subSystem.DoSomeMoreWork();
        }
    }
}
