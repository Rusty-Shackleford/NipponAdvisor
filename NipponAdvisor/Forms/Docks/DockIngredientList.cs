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
using DarkUI.Controls;

namespace NipponAdvisor.Forms.Docks
{
    public partial class DockIngredientList : DarkToolWindow
    {
        #region [ Constructor ]

        #endregion
        public DockIngredientList()
        {
            InitializeComponent();
            LoadIngredients();
        }

        #region [ Load Ingredients ]
        private void LoadIngredients()
        {
            foreach (var category in Program.Ingredients.ByCategory)
            {
                var categoryNode = new DarkTreeNode(category.Key.ToString())
                {
                    ExpandedIcon = GameIcons.BottleOpened_16x,
                    Icon = GameIcons.BottleClosed_16x
                };

                foreach (var ingredient in category)
                {
                    var ingredientNode = new DarkTreeNode(ingredient.Name)
                    {
                        Icon = GameIcons.Mushroom_16x
                    };
                    categoryNode.Nodes.Add(ingredientNode);
                }
                treeIngredients.Nodes.Add(categoryNode);
            }
            treeIngredients.ShowIcons = true;
        }
        #endregion


        #region [ RefreshNodes ]
        public void RefreshNodes()
        {
            // There seems to be an issue with the tree nodes not properly
            // spacing the node icons - expanding / contracting the root
            // properly refreshes the control to assign the right offsets
            // to each icon.
            treeIngredients.Nodes[0].Expanded = true;
            treeIngredients.Nodes[0].Expanded = false;
        }
        #endregion

    }
}
