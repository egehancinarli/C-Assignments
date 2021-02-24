using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
            Console.ReadLine();
        }
        void Start()
        {   // Since BigDataLoader is the main class I can assign them with BigDataLoader keyword.
            BigDataLoader Call = new CallDataLoader();
            BigDataLoader Twitter = new TwitterDataLoader();
            BigDataLoader Sensor = new SensorDataLoader();
            BatchProcessor processor = new BatchProcessor();
            //Adding the processors
            processor.AddBigDataLoader(Call);
            processor.AddBigDataLoader(Twitter);
            processor.AddBigDataLoader(Sensor);
            //Starting the ETL process
            processor.ProcessBigDataLoaders();

           
          
        }
    }
}
