using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Term4Week1
{
    public abstract class BookStoreItem
    {
        
        public string Title { get; set; }
        public float Price { get; set; }
        public int NumberOfItems { get; set; }
        public BookStoreItem(string Title,float Price,int NumberOfItems)
        {
            this.Title = Title;
            this.Price = Price;
            this.NumberOfItems = NumberOfItems;
        }
    }
}
