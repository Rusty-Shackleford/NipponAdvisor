using System;
using DarkUI.Docking;
using DarkUI.Controls;
using NipponAdvisor.DarkUIExt;
using System.Collections.Generic;

namespace NipponAdvisor.Forms.Docks
{
    public partial class DockIngredientList : DarkToolWindowExt
    {
        #region [ Members ]
        public event EventHandler<IngredientsAddedArgs> IngredientsChosen;
        #endregion

        #region [ Constructor ]
        public DockIngredientList(DarkDockArea area) : base(area)
        {
            InitializeComponent();
            LoadIngredients();
        }
        #endregion


        #region [ Load Ingredients ]
        private void LoadIngredients()
        {
            foreach (var category in Program.IngredientsTable.ByCategory)
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
                Tree_Ingredients.Nodes.Add(categoryNode);
            }
            Tree_Ingredients.ShowIcons = true;
        }
        #endregion


        #region [ RefreshNodes ]
        public void RefreshNodes()
        {
            // There seems to be an issue with the tree nodes not properly
            // spacing the node icons - expanding / contracting the root
            // properly refreshes the control to assign the right offsets
            // to each icon.
            Tree_Ingredients.Nodes[0].Expanded = true;
            Tree_Ingredients.Nodes[0].Expanded = false;
        }
        #endregion

        private void Button_AddToInventory_Click(object sender, EventArgs e)
        {
            List<string> selected = new List<string>();

            foreach (var node in Tree_Ingredients.SelectedNodes)
            {
                // If category node, add all children too.
                if (node.Nodes.Count > 0)
                    foreach (var childNode in node.Nodes)
                        selected.Add(childNode.Text);
                else
                    // if not a category, then add the node.
                    selected.Add(node.Text);
            }
            IngredientsChosen?.Invoke(this, new IngredientsAddedArgs(selected));
        }
    }
}
