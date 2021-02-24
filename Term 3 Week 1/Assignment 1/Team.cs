using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Team
    {

        private List<Programmer> programmers;
        public Team()
        {
            programmers = new List<Programmer>();
        }
        public void AddAProgrammer(Programmer p)
        {
            programmers.Add(p);
        }
        public void  PrintAllMembers()
        {
           foreach(Programmer  p in programmers )
            {
                Programmer.Print(p);
            }

        }
    }
}
