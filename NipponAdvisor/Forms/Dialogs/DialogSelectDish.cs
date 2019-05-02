using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Forms;
using NipponAdvisor.CafeItems;
using System.Diagnostics;
using NipponAdvisor.Forms.Docks;

namespace NipponAdvisor.Forms.Dialogs
{
    public partial class DialogSelectDish : DarkDialog
    {
        #region [ Members ]
        public Dish SelectedDish { get; private set; }
        public event EventHandler OnDishSelected;
        private bool _bindingsSet = false;
        #endregion


        #region [ Constructor ]
        public DialogSelectDish()
        {
            InitializeComponent();
            btnOk.Click += BtnOk_Click;
            btnCancel.Click += BtnCancel_Click;
            ComboBaseDish_Load();
        }

        private void RemoveBindings()
        {
            labelBaseRating.DataBindings.Clear();
            labelRecipe.DataBindings.Clear();
            labelPrice.DataBindings.Clear();
            labelTaste.DataBindings.Clear();
            labelAppeal.DataBindings.Clear();
            labelCost.DataBindings.Clear();
            labelNote.DataBindings.Clear();
            _bindingsSet = false;
        }

        private void SetBindings()
        {
            if (_bindingsSet)
                RemoveBindings();

            labelBaseRating.DataBindings.Add("Text", SelectedDish, "Name");
            labelRecipe.DataBindings.Add("Text", SelectedDish, "RecipeDescription");
            labelPrice.DataBindings.Add("Text", SelectedDish, "PriceDescription");
            labelTaste.DataBindings.Add("Text", SelectedDish, "TasteDescription");
            labelAppeal.DataBindings.Add("Text", SelectedDish, "AppealDescription");
            labelCost.DataBindings.Add("Text", SelectedDish, "CostPerMonthDescription");
            labelNote.DataBindings.Add("Text", SelectedDish, "Note");
            _bindingsSet = true;
        }
        #endregion

        private void SetSelectedDish()
        {
            SelectedDish = Program.DishTable.First
                (d => d.Name == ComboBaseDish.SelectedItem.ToString());
            SetBindings();
        }


        #region [ ComboBaseDish ]
        // LOAD COMBO
        private void ComboBaseDish_Load()
        {
            ComboBaseDish.Items.Clear();
            foreach (var dish in Program.DishTable)
            {
                ComboBaseDish.Items.Add(dish.Name);
            }
        }

        // VALIDATE
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

        // VALIDATING
        private void ComboBaseDish_Validating(object sender, CancelEventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            if (!ValidBaseDishComboBox(box, out string errorMessage))
            {
                e.Cancel = true;
                box.Select(0, box.Text.Length);
                box.ForeColor = Color.Orange;
                OnInvalidated(null);
            }
        }

        // VALIDATED: Create SelectedDish
        private void ComboBaseDish_Validated(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            box.ForeColor = Color.Gainsboro;
            Debug.WriteLine($"Selected Dish: {box.SelectedItem}");
            SetSelectedDish();
        }
        #endregion


        #region [ BtnOk ]
        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (ValidBaseDishComboBox(ComboBaseDish, out string err)) {
                if (SelectedDish != null)
                {
                    OnDishSelected?.Invoke(this, EventArgs.Empty);
                    Hide();
                }
            }
        }
        #endregion


        #region [ BtnCancel ]
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void ComboBaseDish_Changed(object sender, EventArgs e)
        {
            SetSelectedDish();
        }
    }
}
