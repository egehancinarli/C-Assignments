using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Term4Week1
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
            BookStore bookStore = new BookStore();
            BookStoreItem TheCure = new CD("Seventeen Seconds",3.90f,5,"The Cure");
            BookStoreItem Dracula = new Book("Dracula",15.00f,5,"Bram Stoker");
            BookStoreItem Joe = new Book("Joe Speedboot", 12.50f, 3, "Tommy Wierga");
            BookStoreItem Time = new Magazine("Time",3.90f,10,DayOfWeek.Friday);
            BookStoreItem DonaldDuck = new Magazine("Donald Duck", 2.50f, 15, DayOfWeek.Thursday);
            bookStore.Add(TheCure);
            bookStore.Add(Dracula);
            bookStore.Add(Joe);
            bookStore.Add(Time);
            bookStore.Add(DonaldDuck);

            bookStore.PrintAllItems();


        }
    }
   
}
