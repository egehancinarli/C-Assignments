using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Term4Week1
{
   public class Magazine : BookStoreItem
    {
        public DayOfWeek ReleaseDay { get; set; }
        public Magazine(string Title,float Price,int NumberOfItems,DayOfWeek ReleaseDay): base(Title,Price,NumberOfItems)
        {
            this.ReleaseDay = ReleaseDay;
        }

        public override string ToString()
        {
            return $"[Magazine] {Title} - {ReleaseDay}, {Price.ToString("0.00")} ({NumberOfItems}x)";
        }

    }
}
