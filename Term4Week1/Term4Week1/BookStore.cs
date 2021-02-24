using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Term4Week1
{
    public class BookStore
    {
        private List<BookStoreItem> bookStoreItems;

       
        public BookStore()
        {
            bookStoreItems = new List<BookStoreItem>();
        }

      
        public void Add(BookStoreItem item)
        {
             bookStoreItems.Add(item);
            
            
        }
        public void PrintAllItems()
        {
            foreach (BookStoreItem B in bookStoreItems)
            {
                Console.WriteLine(B.ToString());
            }
        }


           
    }
}
