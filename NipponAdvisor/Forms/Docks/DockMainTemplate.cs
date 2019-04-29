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
    public partial class DockMainTemplate : DarkToolWindow
    {
        public DockMainTemplate()
        {
            InitializeComponent();
        }

        private void TrackBarStars_Changed(object sender, EventArgs e)
        {
            labelDishRating.Text = trackDishRating.Value.ToString();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}