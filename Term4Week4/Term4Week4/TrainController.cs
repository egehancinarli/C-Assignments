using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Term4Week4
{
    public class TrainController : ITrainController
    {
        private ITrainJourney journey;

        public TrainController(ITrainJourney journey)
        {
            this.journey = journey;
        }

        public void NextStation()
        {
            journey.NextStation();
        }
    }
}
