using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Magazine:BookStoreItem
    {
        private string release_day;
        public Magazine(string title, double price, string release_day)
            : base(title,price)
        {
            this.release_day = release_day;
        }
        public override void Print()
        {
            Console.WriteLine("[MAGAZINE]'{0}'- release day :{1},{2:0.00}",title,release_day,price);
        }
        public override double CalculatePrice(double total)
        {
            total = total + price;

            return total;
        }

    }
}
