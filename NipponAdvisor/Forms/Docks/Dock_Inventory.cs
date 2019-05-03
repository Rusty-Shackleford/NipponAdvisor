using System;
using System.Linq;
using System.Windows.Forms;
using NipponAdvisor.DarkUIExt;
using DarkUI.Docking;
using DarkUI.Controls;
using System.Collections.Generic;
using NipponAdvisor.CafeItems;
using System.Drawing;
using System.ComponentModel;

namespace NipponAdvisor.Forms.Docks
{
    public partial class Dock_Inventory : DarkToolWindowExt
    {
        #region [ Members ]
        private List<Label> InfoLabels;
        #endregion


        #region [ Constructor ]
        public Dock_Inventory(DarkDockArea area) : base(area)
        {
            InitializeComponent();
            LoadIngredients();
            InfoLabels = new List<Label>();
            InfoLabels.Add(Label_Rating);
            InfoLabels.Add(Label_Health);
            InfoLabels.Add(Label_Brain);
            InfoLabels.Add(Label_Texture);
            InfoLabels.Add(Label_Aroma);
            InfoLabels.Add(Label_Appearance);
            InfoLabels.Add(Label_Volume);
            InfoLabels.Add(Label_Rarity);
            InfoLabels.Add(Label_Charisma);

            Cmu_Inventory.Opening += Cmu_Opening;
            // Context Menus
        }

        private void Cmu_Opening(object sender, CancelEventArgs e)
        {
            var selectedItems = List_Inventory.SelectedIndices.Count;
            var totalItems = List_Inventory.Items.Count;

            if (totalItems == 0)
            {
                e.Cancel = true;
                return;
            }

            if (selectedItems != 1)
            {
                CmuMnu_Ingredient1.Enabled = false;
                CmuMnu_Ingredient2.Enabled = false;
            }

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


        #region [ Context Menu: Inventory ]
        private void CmuMnu_Ingredient2_Click(object sender, EventArgs e)
        {

        }

        private void CmuMnu_Ingredient1_Click(object sender, EventArgs e)
        {

        }

        private void CmuMnu_RemoveAll_Click(object sender, EventArgs e)
        {
            List_Inventory.Items.Clear();
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


        #region [ Sort Inventory ]
        private void SortInventory()
        {
            var sortedItems = List_Inventory.Items.OrderBy(o => o.Text).ToList();
            List_Inventory.Items.Clear();
            foreach (var item in sortedItems)
            {
                List_Inventory.Items.Add(item);
            }
        }
        #endregion


        #region [ Inventory: Add / Remove ]
        // [ADD Ingredient]: Button
        private void Button_AddToInventory_Click(object sender, EventArgs e)
        {
            foreach (var node in Tree_Ingredients.SelectedNodes)
            {
                // If category node, add all children too.
                if (node.Nodes.Count > 0)
                    foreach (var childNode in node.Nodes)
                        List_Inventory.Items.Add(new DarkListItem(childNode.Text));
                else
                    // if not a category, then add the node.
                    List_Inventory.Items.Add(new DarkListItem(node.Text));
            }
        }

        // [REMOVE Ingredient]: Button
        private void Button_Remove_Click(object sender, EventArgs e)
        {
            int totalItems = List_Inventory.Items.Count;
            int selectedItems = List_Inventory.SelectedIndices.Count;

            if (totalItems < 2 || selectedItems == totalItems)
            {
                List_Inventory.Items.Clear();
                List_Inventory.SelectedIndices.Clear();
                return;
            }
            foreach (var idx in List_Inventory.SelectedIndices)
            {
                if (List_Inventory.Items.ElementAtOrDefault(idx) != null)
                    List_Inventory.Items.RemoveAt(idx);
            }
            List_Inventory.SelectedIndices.Clear();
            ClearIngredientInfo();
        }

        // [REMOVE]: Double Click
        private void List_Inventory_DoubleClick(object sender, EventArgs e)
        {
            if (List_Inventory.SelectedIndices.Count > 0)
            {
                Button_Remove_Click(this, EventArgs.Empty);
            }
        }

        // [ADD]: Double Click
        private void Tree_Ingredients_DoubleClick(object sender, EventArgs e)
        {
            if (Tree_Ingredients.SelectedNodes.Count > 0)
            {
                Button_AddToInventory_Click(this, EventArgs.Empty);
            }
        }
        #endregion


        #region [ Show Ingredient Info ]
        private void List_Inventory_ShowInfo(object sender, EventArgs e)
        {
            if (List_Inventory.SelectedIndices.Count > 0)
            {
                int idx = List_Inventory.SelectedIndices[0];
                string name = List_Inventory.Items.ElementAtOrDefault(idx).Text;
                if (!string.IsNullOrEmpty(name))
                    ShowIngredientInfo(name);
            }
        }


        private void ShowIngredientInfo(string name)
        {
            Ingredient ing = Program.IngredientsTable.GetIngredientByName(name);
            if (ing != null)
            {
                DSP_Info.SectionHeader = "Info: " + ing.Name;
                Label_Rating.Text = ing.Rating.ToString();
                ColorizeLabel(Label_Rating, ing.Rating);

                Label_Health.Text = ing.Health.ToString();
                ColorizeLabel(Label_Health, ing.Health);

                Label_Brain.Text = ing.Brain.ToString();
                ColorizeLabel(Label_Brain, ing.Brain);

                Label_Texture.Text = ing.Texture.ToString();
                ColorizeLabel(Label_Texture, ing.Texture);

                Label_Aroma.Text = ing.Aroma.ToString();
                ColorizeLabel(Label_Aroma, ing.Aroma);

                Label_Appearance.Text = ing.Appearance.ToString();
                ColorizeLabel(Label_Appearance, ing.Appearance);

                Label_Volume.Text = ing.Volume.ToString();
                ColorizeLabel(Label_Volume, ing.Volume);

                Label_Rarity.Text = ing.Rarity.ToString();
                ColorizeLabel(Label_Rarity, ing.Rarity);

                Label_Charisma.Text = ing.Charisma.ToString();
                ColorizeLabel(Label_Charisma, ing.Charisma);
            }
        }


        private void ColorizeLabel(Label label, int value)
        {
            if (value < 0)
                label.ForeColor = Color.FromArgb(218, 88, 61);
            if (value > 4)
                label.ForeColor = Color.FromArgb(104, 189, 62);
        }


        private void ClearIngredientInfo()
        {
            DSP_Info.SectionHeader = "Info";
            Label_Rating.Text = "---";
            Label_Health.Text = "---";
            Label_Brain.Text = "---";
            Label_Texture.Text = "---";
            Label_Aroma.Text = "---";
            Label_Appearance.Text = "---";
            Label_Volume.Text = "---";
            Label_Rarity.Text = "---";
            Label_Charisma.Text = "---";
            foreach (var label in InfoLabels)
            {
                label.ForeColor = Color.FromArgb(220, 220, 220);
            }
        }

        #endregion


    }
}
