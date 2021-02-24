using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Term_3_Week_3
{
    class Bookstore
    {
        private List<BookStoreItem> BookStore = new List<BookStoreItem>();


        public void AddStuff(BookStoreItem b)
        {
            BookStore.Add(b);
        }

        public void PrintTheStock()
        {
            double amount = 0;
            foreach (BookStoreItem a in BookStore)
            {
                a.Print();
                amount = a.CalculatePrice(amount);
            }
            Console.WriteLine("Total sales price : {0:0.00}",amount);
        }
    }
}
