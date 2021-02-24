using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Term_3_Week_3
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
            Book Dracula = new Book("Dracula", "Bram Stoker", 15,5);
            Book Joe = new Book("Joe Speedboot", "Tommy Wieringa", 12.50,5);
            Book Hobbit = new Book("The Hobbit", "J.r.r Tolkien", 12.50,4);
            Store.AddStuff(Dracula);
            Store.AddStuff(Joe);
            Store.AddStuff(Hobbit);
            Magazine Duck = new Magazine("Donald Duck", 2.50, "Thursday",8);
            Magazine Time = new Magazine("Time", 3.90, "Friday",10);
            Store.AddStuff(Duck);
            Store.AddStuff(Time);
            Store.PrintTheStock();
        }
    }
}
