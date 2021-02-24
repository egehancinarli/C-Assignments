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
            Bookstore Store = new Bookstore();
            Book Dracula = new Book("Cosminita and his banana",15,"Bram Stoker");
            Book Joe = new Book("Joe Speedboot",12.50,"Tommy Wieringa");
            Book Hobbit = new Book("The Hobbit",12.50,"J.r.r Tolkien");
            Store.AddStuff(Dracula);
            Store.AddStuff(Joe);
            Store.AddStuff(Hobbit);
            Magazine Duck = new Magazine("Donald Duck",2.50,"Thursday");
            Magazine Time = new Magazine("Time", 3.90, "Friday");
            Store.AddStuff(Duck);
            Store.AddStuff(Time);
            Store.PrintTheStock();
        }
    }
}
