using DarkUI.Docking;
using DarkUI.Forms;
using NipponAdvisor.CafeItems;
using NipponAdvisor.DarkUIExt;
using NipponAdvisor.Forms.Dialogs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;


namespace NipponAdvisor.Forms.Docks
{
    public partial class Dock_ChosenDish : DarkToolWindowExt
    {
        #region [ Members ]
        public CraftedDish Dish { get; set; }
        private List<Control> _dishFields = new List<Control>();
        private bool _bindingsSet = false;
        #endregion


        #region [ Constructor ]
        public Dock_ChosenDish(DarkDockArea area) : base(area)
        {
            InitializeComponent();

            _dishFields.Add(TextBox_Name);
            _dishFields.Add(Slider_Rating);
            _dishFields.Add(TextBox_Health);
            _dishFields.Add(TextBox_Brain);
            _dishFields.Add(TextBox_Texture);
            _dishFields.Add(TextBox_Aroma);
            _dishFields.Add(TextBox_Appearance);
            _dishFields.Add(TextBox_Volume);
            _dishFields.Add(TextBox_Rarity);
            _dishFields.Add(TextBox_Charisma);
        }

        #endregion


        #region [ Add/Remove Bindings ]
        private void RemoveBindings()
        {
            foreach (var control in _dishFields)
            {
                control.DataBindings.Clear();
                control.Text = "";
                if (control is TrackBar)
                {
                    TrackBar c = (TrackBar)control;
                    c.Value = 1;
                }
            }
            _bindingsSet = false;
        }


        private void SetBindings()
        {
            if (_bindingsSet)
                RemoveBindings();

            if (Dish != null)
            {
                foreach (var control in _dishFields)
                {
                    var nameParts = (control.Name).Split('_').ToList();
                    var cName = nameParts[1];
                    string fieldType = "Text";
                    if (control.GetType() == typeof(TrackBar))
                        fieldType = "Value";

                    control.DataBindings.Add(fieldType, Dish, cName);
                }
            }
            _bindingsSet = true;
        }
        #endregion


        #region [ Slider: Rating ]
        private void Rating_Changed(object sender, EventArgs e)
        {
            labelRating.Text = Slider_Rating.Value.ToString();
        }
        #endregion


        #region [ Button: New Dish ]
        public void CreateNewDish()
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
            // Open Dish Selection
            ShowSelectDialog();
        }

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
            // Open Dish Selection
            ShowSelectDialog();
        }


        private void Notify_DishSelected(object sender, DishChangedArgs e)
        {
            Dish = new CraftedDish(e.NewDish);
            // Notify other docks that rely on the selected dish.
            OnDishChanged(e);
            SetBindings();
        }

        private void ShowSelectDialog()
        {
            var dialog = new DialogSelectDish();
            dialog.DishSelected += Notify_DishSelected;
            dialog.Show(this as Dock_ChosenDish);
        }
        #endregion
    }
}