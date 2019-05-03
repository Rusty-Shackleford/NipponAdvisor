using NipponAdvisor.DarkUIExt;

namespace NipponAdvisor.Forms.Docks
{
    partial class DockIngredientList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.Button_AddToInventory = new DarkUI.Controls.DarkButton();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.Tree_Ingredients = new DarkUI.Controls.DarkTreeView();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.Button_AddToInventory);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 25);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(0, 5, 0, 8);
            this.panelTop.Size = new System.Drawing.Size(163, 35);
            this.panelTop.TabIndex = 0;
            // 
            // Button_AddToInventory
            // 
            this.Button_AddToInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_AddToInventory.Location = new System.Drawing.Point(0, 5);
            this.Button_AddToInventory.Name = "Button_AddToInventory";
            this.Button_AddToInventory.Padding = new System.Windows.Forms.Padding(5);
            this.Button_AddToInventory.Size = new System.Drawing.Size(163, 22);
            this.Button_AddToInventory.TabIndex = 0;
            this.Button_AddToInventory.Text = "Add to My Inventory";
            this.Button_AddToInventory.Click += new System.EventHandler(this.Button_AddToInventory_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.Tree_Ingredients);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(0, 60);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(163, 178);
            this.panelBottom.TabIndex = 1;
            // 
            // Tree_Ingredients
            // 
            this.Tree_Ingredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tree_Ingredients.Location = new System.Drawing.Point(0, 0);
            this.Tree_Ingredients.MaxDragChange = 20;
            this.Tree_Ingredients.MultiSelect = true;
            this.Tree_Ingredients.Name = "Tree_Ingredients";
            this.Tree_Ingredients.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.Tree_Ingredients.Size = new System.Drawing.Size(163, 178);
            this.Tree_Ingredients.TabIndex = 1;
            // 
            // DockIngredientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.DockText = "Ingredient List";
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Icon = global::NipponAdvisor.GameIcons.ingredient_16x;
            this.Name = "DockIngredientList";
            this.Size = new System.Drawing.Size(163, 238);
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private DarkUI.Controls.DarkTreeView Tree_Ingredients;
        private DarkUI.Controls.DarkButton Button_AddToInventory;
    }
}
