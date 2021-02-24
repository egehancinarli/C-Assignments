using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    abstract class BookStoreItem
    {
        protected string title;
        protected double price;
         
        public BookStoreItem (string title,double price)
        {
            this.title = title;
            this.price = price;
        }
        public abstract void Print();



        public abstract double CalculatePrice(double total);
        

        
    }
}
