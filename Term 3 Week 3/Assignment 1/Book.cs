using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Book :BookStoreItem
    {
        private string author;
       

       
        public Book(string title,double price,string author):base(title,price)
        {
            this.author = author;

        }
        
        public override void Print()
        {
            Console.WriteLine("[BOOK]'{0}' by {1}, {2:00}",title,author,price);
        }
        public override double CalculatePrice(double total)
        {
            total = total +price;
            
            return total;
        }
    }
}
