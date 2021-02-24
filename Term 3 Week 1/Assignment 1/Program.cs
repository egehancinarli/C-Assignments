using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
            Console.ReadKey();
        }
        void Start()
        {
            Team TeamAlpha = new Team();
            TeamAlpha.PrintAllMembers();
            Console.WriteLine("\n\n");
            Programmer p1 = new Programmer("Trevor", Speciality.PHP);
            Programmer p2 = new Programmer("Yoda", Speciality.Java);
            Programmer p3 = new Programmer("Cosmin", Speciality.CSharp);
            Programmer p4 = new Programmer("Ezgi", Speciality.HTML);


            Programmer ege = new Programmer("ege",Speciality.CSharp);
            Programmer Emma = new Programmer("Emma");
            TeamAlpha.AddAProgrammer(ege);
            TeamAlpha.AddAProgrammer(Emma);
            TeamAlpha.AddAProgrammer(p1);
            TeamAlpha.AddAProgrammer(p2);
            TeamAlpha.AddAProgrammer(p3);
            TeamAlpha.AddAProgrammer(p4);

            TeamAlpha.PrintAllMembers();


        }
    }
}
