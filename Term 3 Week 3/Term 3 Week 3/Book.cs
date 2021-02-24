using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Term_3_Week_3
{
     class Book :BookStoreItem
    {
        
        private string author;
        
       
        public Book(string title, string author, double price, int count) : base(title, price,count)
        {
            this.author = author;
        }

        public string Author
        {
            get
            {
                return author;
            }
        }

        public override void Print()
        {
            Console.WriteLine("[BOOK]'{0}' by {1}, {2:00} ({3}x)", Title, Author, Price,Count);
        }
        public override double CalculatePrice(double total)
        {
            
            calculate = (price*count);
            total = total + calculate;

            return total;
        }
    }
}
