using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class BatchProcessor
    {
        List<BigDataLoader> loaders;
        public BatchProcessor()
        {
            loaders = new List<BigDataLoader>();
        }

        public void  AddBigDataLoader(BigDataLoader loader)
        {
            loaders.Add(loader);
        }
        public void ProcessBigDataLoaders()
        {
            foreach(BigDataLoader loader in loaders)
            {
                loader.StartEtlProcess();
                Console.WriteLine(); // For a new line.
            }
        }

    }
}
