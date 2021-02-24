using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Programmer
    {
        private Speciality specs;
        private string name;
        public Programmer(string name, Speciality specs)
        {
            this.name = name;
            this.specs = specs;
        }
        public Programmer(string name) :this( name , Speciality.Unkown)
        {    
        }
        
        public static void Print(Programmer programmer)
        {
            Console.WriteLine("Name :  {0} , Speciality : {1} ",programmer.name,programmer.specs);
        }

    }
    
}
