using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Term4Week4
{
    public class TrainStation
    {
        public string Name { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
        public string ArrivalTrack { get; set; }
        public TrainStation(string Name, DateTime ArrivalTime, DateTime DepartureTime, string ArrivalTrack)
        {
            this.Name = Name;
            this.ArrivalTime = ArrivalTime;
            this.DepartureTime = DepartureTime;
            this.ArrivalTrack = ArrivalTrack;
        }
    }
}
