using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class TwitterDataLoader : BigDataLoader
    {
        public override void Extract()
        {
            Console.WriteLine("Extracting Twitter data...");
        }

        public override void Load()
        {
            Console.WriteLine("Loading Twitter data...");
        }

        public override void Transform()
        {
            Console.WriteLine("Transforming Twitter data...");
        }
    }
}
