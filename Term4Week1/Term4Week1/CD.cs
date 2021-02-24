using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Term4Week1
{
    public class CD : BookStoreItem
    {
        public string Artist { get; set; }
        public CD (string Title, float Price, int NumberOfItems, string Artist) : base(Title, Price, NumberOfItems)
        {
            this.Artist = Artist;
        }
        public override string ToString()
        {
            return $"[CD] {Title} - {Artist}, {Price.ToString("0.00")} ({NumberOfItems}x)";
        }
    }
}
