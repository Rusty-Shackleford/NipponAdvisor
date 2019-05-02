using System;
using DarkUI.Docking;
using DarkUI.Controls;
using NipponAdvisor.DarkUIExt;


namespace NipponAdvisor.Forms.Docks
{
    public partial class DockIngredientList : DarkToolWindowExt
    {
        #region [ Members ]
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
