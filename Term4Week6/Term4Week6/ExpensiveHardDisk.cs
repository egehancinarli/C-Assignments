using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Term4Week6
{
    public class ExpensiveHardDisk : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("Storing data very quickly");
        }
    }
}
