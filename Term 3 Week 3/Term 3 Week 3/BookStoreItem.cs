using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Term_3_Week_3
{
   abstract class BookStoreItem
    {
        protected string title;
        protected double price;
        protected int count;
        protected double calculate;

        public BookStoreItem(string title, double price,int count)
        {
            this.title = title;
            this.price = price;
            this.count = count;
        }
        public double Calculate
        {
            get
            {
                return Calculate;
            }
        }
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }
       
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public abstract void Print();

      public abstract double CalculatePrice(double total);
    }
}
