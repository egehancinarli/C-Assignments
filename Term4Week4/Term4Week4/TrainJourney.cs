using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Term4Week4
{
    public class TrainJourney : ITrainJourney
    {
        List<TrainStation> Stations;
        bool IsMovingForwards = true; //if true it is going towards last station, if false it's going towards first station.
        public TrainStation CurrentStation { get; private set; }

        List<ITrainDisplay> TrainDisplays;
        public TrainJourney()
        {
            Stations = new List<TrainStation>();
            AddStations();
            TrainDisplays = new List<ITrainDisplay>();
            CurrentStation = Stations[0];

        }
        private void AddStations()
        {
            Stations.Add(new TrainStation("Aalten", DateTime.Parse("25-04-2020 12:10:06"), DateTime.Parse("25-04-2020 13:10:06"), "B4"));
            Stations.Add(new TrainStation("Abcoude", DateTime.Parse("25-04-2020 13:25:00"), DateTime.Parse("25-04-2020 15:10:06"), "C3"));
            Stations.Add(new TrainStation("Alkmaar North", DateTime.Parse("25-04-2020 18:30:00"), DateTime.Parse("25-04-2020 19:00:00"), "O8"));
            Stations.Add(new TrainStation("Overveen", DateTime.Parse("25-04-2020 16:30:00"), DateTime.Parse("25-04-2020 18:00:00"), "K3"));
            Stations.Add(new TrainStation("Opusus", DateTime.Parse("25-04-2020 19:30:00"), DateTime.Parse("25-04-2020 21:00:00"), "F10"));
            Stations.Add(new TrainStation("Wells", DateTime.Parse("25-04-2020 19:10:00"), DateTime.Parse("25-04-2020 21:00:00"), "F3"));
            Stations.Add(new TrainStation("Roermond", DateTime.Parse("25-04-2020 20:30:00"), DateTime.Parse("25-04-2020 21:00:00"), "E3"));
            Stations.Add(new TrainStation("Rotterdam Blaak", DateTime.Parse("25-04-2020 23:30:00"), DateTime.Parse("25-04-2020 01:00:00"), "B3"));

        }

        public void AddObserver(ITrainDisplay display)
        {
            TrainDisplays.Add(display);
            display.Update(CurrentStation);
        }
        public void RemoveObserver(ITrainDisplay display) // There was no button for remove is this necessary ?
        {
            TrainDisplays.Remove(display);
        }
        private void NotifyTheDisplayers()
        {
            foreach (ITrainDisplay display in TrainDisplays)
            {
                display.Update(CurrentStation);
            }
        }

        public void NextStation()
        {
            int index = Stations.IndexOf(CurrentStation);
            //if it's the last station return back.
            // else if it's the first station start going forward again.
            if (Stations[index] == Stations[Stations.Count - 1])
                IsMovingForwards = false;
            else if (Stations[index] == Stations[0])
                IsMovingForwards = true;

            //if train is goin to the last station and it's not in the last station, then go to the next station.
            // else if train is returning back, and it's not the first station, keep going back.
            if (IsMovingForwards)
                CurrentStation = Stations[index + 1];
            else
                CurrentStation = Stations[index - 1];
            // notify the displayers to update the next station.
            NotifyTheDisplayers();
        }
    }
}
