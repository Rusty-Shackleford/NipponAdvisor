using DarkUI.Docking;
using DarkUI.Forms;
using NipponAdvisor.CafeItems;
using NipponAdvisor.DarkUIExt;
using NipponAdvisor.Forms.Dialogs;
using System;
using System.Diagnostics;
using System.Windows.Forms;


namespace NipponAdvisor.Forms.Docks
{
    public partial class DockCafeDish : DarkToolWindowExt
    {
        #region [ Members ]
        public CraftedDish Dish { get; set; }
        #endregion


        #region [ Constructor ]
        public DockCafeDish(DarkDockArea area) : base(area)
        {
            InitializeComponent();
        }
        #endregion

        #region [ SetBindings ]
        private void SetBindings()
        {
            if (Dish != null)
            {
                //TB_userName.DataBindings.Add("Text", userToBind, "name");
                TextBoxBaseDish.DataBindings.Add("Text", Dish, "BaseDish.Name");
            }
        }
        #endregion


        #region [ Slider: Rating ]
        private void Rating_Changed(object sender, EventArgs e)
        {
            labelRating.Text = SliderRating.Value.ToString();
        }
        #endregion


        #region [ Button: New Dish ]
        private void BtnNewDish_Click(object sender, EventArgs e)
        {
            if (Dish != null)
            {
                var result = DarkMessageBox.ShowInformation("Would you like to save the current dish?", "Save Dish?", DarkDialogButton.YesNo);
                if (result == DialogResult.Yes)
                {
                    //TODO: SAVE DISH
                    Debug.WriteLine("Note: Save Dish is not implemented yet.");
                }
            }

            DialogSelectDish selectDish = new DialogSelectDish();
            selectDish.OnDishSelected += NewCraftedDish;
            selectDish.Show(this as DockCafeDish);
        }

        private void NewCraftedDish(object sender, EventArgs e)
        {
            DialogSelectDish dialog = (DialogSelectDish)sender;
            Dish = new CraftedDish(dialog.SelectedDish);
            SetBindings();
        }
        #endregion
    }
}
