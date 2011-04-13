using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AR.DroneWorkstation
{
    public partial class CameraWindow : Form
    {
        InstrumentPanel Instruments;
        ControlPanel Settings;
        public CameraWindow()
        {
            InitializeComponent();
        }

        private void CameraWindow_Load(object sender, EventArgs e)
        {
            StartupTimer.Enabled = true;
            
        }

        private void StartupTimer_Tick(object sender, EventArgs e)
        {
            StartupTimer.Enabled = false;
            Instruments = new InstrumentPanel();
            Instruments.Location = this.Location;
            Instruments.Location.Offset(new Point(0, 483));
            Instruments.Show();
            Settings = new ControlPanel();
            Settings.Location = this.Location;
            Settings.Location.Offset(new Point(594, 0));
            Settings.Show();
            StartupTimer.Dispose();
        }

        

    }
}
