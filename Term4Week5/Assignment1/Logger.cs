using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Logger
    {
        private static Logger uniqueInstance;
        private static int numberOfLines = 1;

        private Logger() { }

        public static Logger GetInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new Logger();

            return uniqueInstance;
        }

        public void Log(string systemType,string specificSystemMessage)
        {
            Console.WriteLine($"{numberOfLines}- [{systemType}] {specificSystemMessage}");
            numberOfLines++;
        }
       
    }
}
