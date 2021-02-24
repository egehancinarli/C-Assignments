using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Term4Week1
{
    public class Book : BookStoreItem
    {
        public string Author { get; set; }

        public Book (string Title, float Price, int NumberOfItems, string Author) : base(Title, Price, NumberOfItems)
        {
            this.Author = Author;
        }
        public override string ToString()
        {
            return $"[Book] {Title} - {Author}, {Price.ToString("0.00")} ({NumberOfItems}x)";
        }
    }
}
