namespace NipponAdvisor.Forms.Docks
{
    partial class DockInventory
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
            this.List_Inventory = new DarkUI.Controls.DarkListView();
            this.SuspendLayout();
            // 
            // List_Inventory
            // 
            this.List_Inventory.AllowDrop = true;
            this.List_Inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List_Inventory.Location = new System.Drawing.Point(0, 25);
            this.List_Inventory.Name = "List_Inventory";
            this.List_Inventory.Size = new System.Drawing.Size(187, 262);
            this.List_Inventory.TabIndex = 0;
            this.List_Inventory.Text = "darkListView1";
            this.List_Inventory.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListInventory_DragDrop);
            // 
            // DockInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.List_Inventory);
            this.DockText = "My Ingredients";
            this.Icon = global::NipponAdvisor.GameIcons.Mushroom_16x;
            this.Name = "DockInventory";
            this.Size = new System.Drawing.Size(187, 287);
            this.ResumeLayout(false);

        }

        #endregion

        private DarkUI.Controls.DarkListView List_Inventory;
    }
}
