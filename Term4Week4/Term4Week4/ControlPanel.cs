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
    public partial class ControlPanel : Form
    {
        ITrainJourney journey; //these are here because button methods need to be able to reach them.
        ITrainController controller;
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            journey = new TrainJourney();
            controller = new TrainController(journey);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            controller.NextStation();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            TrainDisplay display = new TrainDisplay(journey);
            display.Show();
        }
    }
}
