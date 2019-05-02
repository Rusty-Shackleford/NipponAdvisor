using System;
using System.Linq;
using System.Windows.Forms;
using DarkUI.Forms;
using NipponAdvisor.CafeItems;
using NipponAdvisor.DarkUIExt;
using NipponAdvisor.Forms.Docks;

namespace NipponAdvisor.Forms.Dialogs
{
    public partial class DialogSelectDish : DarkDialog
    {
        #region [ Members ]
        public bool ViewOnly { get; set; }

        // Setting Selected Dish
        // Updating Bindings
        // Set the combobox
        public Dish SelectedDish { get; private set; }
        public event EventHandler<DishChangedArgs> DishSelected;
        private bool _bindingsSet = false;
        #endregion


        #region [ Constructor ]
        public DialogSelectDish()
        {
            InitializeComponent();

            // Load Drop Down
            ComboBaseDish_Load();
            ViewOnly = false;

            // Hook into own events
            btnOk.Click += BtnOk_Click;
            btnCancel.Click += BtnCancel_Click;
            Activated += ActivatedCheck;
            
        }
        #endregion


        #region [ Activate / Close Events ]
        private void ActivatedCheck(object sender, EventArgs e)
        {

            if (ViewOnly)
            {
                Combo_BaseDish.Enabled = false;
                btnOk.Enabled = false;
            }
            else
            {
                Combo_BaseDish.Enabled = true;
                btnOk.Enabled = true;
            }

        }

        private void CloseMe(object sender, FormClosingEventArgs e)
        {
            Close();
        }

        public void SetComboBaseDish(string dishName)
        {
            Combo_BaseDish.SelectedItem = dishName;
        }
        #endregion


        #region [ Data Bindings ]
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

        private void RefreshBindings()
        {
            if (_bindingsSet)
                RemoveBindings();

            Combo_BaseDish.SelectedItem = SelectedDish.Name;

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


        #region [ Load DropDown Options ]
        private void ComboBaseDish_Load()
        {
            Combo_BaseDish.Items.Clear();
            foreach (var dish in Program.DishTable.Records)
            {
                Combo_BaseDish.Items.Add(dish.Name);
            }
        }
        #endregion


        #region [ BtnOk ]
        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (SelectedDish != null)
            {
                DishSelected?.Invoke(this, new DishChangedArgs(SelectedDish));
                Close();
            }
        }
        #endregion


        #region [ BtnCancel ]
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion


        #region [ DropDown Item Changed ]
        private void ComboBaseDish_Changed(object sender, EventArgs e)
        {
            SelectedDish = Program.DishTable.GetDishByName(
                Combo_BaseDish.SelectedItem.ToString()
            );
            RefreshBindings();
        }
        #endregion
    }
}
