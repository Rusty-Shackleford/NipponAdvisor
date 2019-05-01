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
using NipponAdvisor.CafeItems;
using NipponAdvisor.DarkUIExt;

namespace NipponAdvisor.Forms.Docks
{
    public partial class DockDish : DarkToolWindowExt
    {
        #region [ Members ]
        public CraftedDish UserDish { get; set; }
        #endregion

        #region [ Constructor ]
        public DockDish(DarkDockArea area) : base(area)
        {
            InitializeComponent();
        }

        private void DockDish_Load(object sender, EventArgs e)
        {
            LoadComboBaseDish();
            DockDish_Reset();
        }

        private void DockDish_Reset()
        {
            UserDish = new CraftedDish();
            textDishName.Text = "Dish Nickname";
            ComboBaseDish.SelectedIndex = 0;
            sliderRating.Value = 1;
        }
        #endregion


        #region [ UI Events ]
        private void Rating_Changed(object sender, EventArgs e)
        {
            labelRating.Text = sliderRating.Value.ToString();
        }
        #endregion


        #region [ ComboBox: Base Dish ]
        private void LoadComboBaseDish()
        {
            ComboBaseDish.Items.Clear();
            foreach (var dish in Program.DishTable)
            {
                ComboBaseDish.Items.Add(dish.Name);
            }
        }

        private void ComboBaseDish_Validating(object sender, CancelEventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            if (!ValidBaseDishComboBox(box, out string errorMessage))
            {
                e.Cancel = true;
                box.Select(0, box.Text.Length);
                box.ForeColor = Color.Orange;
                OnInvalidated(null);
                OnStatusUpdate(new StatusMessageArgs(errorMessage, StatusType.Error));
            }
        }

        private void ComboBaseDish_Validated(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            box.ForeColor = Color.Gainsboro;
            OnStatusUpdate(new StatusMessageArgs(StatusType.Clear));
        }

        private bool ValidBaseDishComboBox(ComboBox combo, out string errorMessage)
        {
            errorMessage = "";
            if (string.IsNullOrEmpty(combo.Text))
            {
                errorMessage = "Please select a base dish.";
                return false;
            }
            if (!combo.Items.Contains(combo.Text))
            {
                errorMessage = "Please select a base dish.";
                return false;
            }
            return true;
        }
        #endregion

    }
}