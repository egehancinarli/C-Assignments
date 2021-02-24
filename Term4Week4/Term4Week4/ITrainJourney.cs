using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Term4Week4
{
   public interface ITrainJourney
    {
      TrainStation CurrentStation { get; }
        void NextStation();
       
        void AddObserver(ITrainDisplay display);
        void RemoveObserver(ITrainDisplay display);
     
    }
}
