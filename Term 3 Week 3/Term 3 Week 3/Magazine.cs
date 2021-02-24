using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Term_3_Week_3
{
    class Magazine:BookStoreItem
    {
        private string release_day;

        public string Release
        {
            get
            {
                return release_day;
            }
        }
        public Magazine(string title, double price, string release_day,int count)
            : base(title, price,count)
        {
            this.release_day = release_day;
        }
        public override void Print()
        {
            Console.WriteLine("[MAGAZINE]'{0}'- release day :{1},{2:0.00} ({3}x)", Title, Release, Price,Count);
        }
        public override double CalculatePrice(double total)
        {

            calculate = (price * count);
            total = total + calculate;

            return total;
        }
    }
}
