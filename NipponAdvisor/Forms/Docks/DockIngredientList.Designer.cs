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
            this.treeIngredients = new DarkUI.Controls.DarkTreeView();
            this.SuspendLayout();
            // 
            // treeIngredients
            // 
            this.treeIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeIngredients.Location = new System.Drawing.Point(0, 25);
            this.treeIngredients.MaxDragChange = 20;
            this.treeIngredients.Name = "treeIngredients";
            this.treeIngredients.Size = new System.Drawing.Size(166, 298);
            this.treeIngredients.TabIndex = 0;
            this.treeIngredients.Text = "W";
            // 
            // DockIngredientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeIngredients);
            this.DockText = "Ingredient List";
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Icon = global::NipponAdvisor.GameIcons.ingredient_16x;
            this.Name = "DockIngredientList";
            this.Size = new System.Drawing.Size(166, 323);
            this.ResumeLayout(false);

        }

        #endregion

        private DarkUI.Controls.DarkTreeView treeIngredients;
    }
}
