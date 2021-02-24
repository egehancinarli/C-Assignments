using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class SubSystem
    {
        private Logger loggerInstance;
        public SubSystem()
        {
            loggerInstance = Logger.GetInstance();
        }
        public void DoSomeMoreWork()
        {
            loggerInstance.Log("SubSystem","Doing Some more work");
        }
        public void DoSomeWork()
        {
            loggerInstance.Log("SubSystem", "Doing some work");
        }
    }
}
