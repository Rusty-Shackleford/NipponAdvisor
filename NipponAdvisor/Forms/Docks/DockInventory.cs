using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NipponAdvisor.DarkUIExt;

namespace NipponAdvisor.Forms.Docks
{
    public partial class DockInventory : DarkToolWindowExt
    {
        public DockInventory()
        {
            InitializeComponent();
        }

        private void ListInventory_DragDrop(object sender, DragEventArgs e)
        {
            Console.WriteLine("got here");
        }
    }
}
