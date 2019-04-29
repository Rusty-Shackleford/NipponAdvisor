using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Docking;

namespace NipponAdvisor.Forms.Docks
{
    public partial class DockDish : DarkToolWindow
    {
        public DockDish()
        {
            InitializeComponent();
        }

        private void Rating_Changed(object sender, EventArgs e)
        {
            labelRating.Text = sliderRating.Value.ToString();
        }
    }
}