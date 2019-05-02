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
using NipponAdvisor.CafeItems;
using DarkUI.Docking;

namespace NipponAdvisor.Forms.Docks
{
    public partial class DockDishInfo : DarkToolWindowExt
    {
        #region [ Members ]
        private DarkToolWindowExt _owner;
        #endregion


        #region [ Constructor ]
        public DockDishInfo(DarkToolWindowExt owner, DarkDockArea area) 
            : base(area)
        {
            InitializeComponent();
            _owner = owner;
            _owner.DishChanged += Update;
        }
        #endregion


        #region [ Set Dish ]
        public void Update(object sender, DishChangedArgs e)
        {
            var dish = e.NewDish;
            if(dish != null)
            {
                Label_BaseRating.Text = dish.BaseRating.ToString();
                Label_CostPerMonthDescription.Text = dish.CostPerMonthDescription;
                Label_PriceDescription.Text = dish.PriceDescription;
                Label_TasteDescription.Text = dish.TasteDescription;
                Label_AppealDescription.Text = dish.AppealDescription;
                Label_RecipeDescription.Text = dish.RecipeDescription;
                Label_Note.Text = dish.Note;
            }
        }
        #endregion


    }
}
