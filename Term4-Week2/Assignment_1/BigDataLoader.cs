using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public abstract class BigDataLoader
    {
        public void StartEtlProcess()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[ETL-process started]");
            Console.ResetColor();
            Extract();
            Transform();
            Load();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[ETL-process finished]");
            Console.ResetColor();
        }

        public abstract void Transform();
        public abstract void Extract();
        public abstract void Load();
            

            
    }
}
