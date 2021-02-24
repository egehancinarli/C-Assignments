using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Term4Week4
{
    public partial class TrainDisplay : Form, ITrainDisplay
    {
        ITrainJourney journey;
        public TrainDisplay(ITrainJourney journey)
        {
            InitializeComponent();
            this.journey = journey;
            this.journey.AddObserver(this);

        }
        private void TrainDisplay_Load(object sender, EventArgs e)
        {

        }

        public void Update(TrainStation station)
        {

            lblcurstation.Text = station.Name;
            lblTrack.Text = station.ArrivalTrack;
            lblArrive.Text = station.ArrivalTime.ToString();
            lblDeparture.Text = station.DepartureTime.ToString();
        }


    }
}
