namespace NipponAdvisor.Forms.Docks
{
    partial class Dock_Inventory
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
            this.Panel_Left = new System.Windows.Forms.Panel();
            this.DSP_Ingredients = new DarkUI.Controls.DarkSectionPanel();
            this.Tree_Ingredients = new DarkUI.Controls.DarkTreeView();
            this.Panel_AddRemove = new System.Windows.Forms.Panel();
            this.Panel_AddRemove_Bottom = new System.Windows.Forms.Panel();
            this.Panel_RemoveIngredient = new System.Windows.Forms.Panel();
            this.Button_Remove = new DarkUI.Controls.DarkButton();
            this.Panel_AddIngredient = new System.Windows.Forms.Panel();
            this.Button_Add = new DarkUI.Controls.DarkButton();
            this.Panel_AddRemove_Top = new System.Windows.Forms.Panel();
            this.DSP_Inventory = new DarkUI.Controls.DarkSectionPanel();
            this.panelInventory = new System.Windows.Forms.Panel();
            this.List_Inventory = new DarkUI.Controls.DarkListView();
            this.Cmu_Inventory = new DarkUI.Controls.DarkContextMenu();
            this.CmuMnu_Ingredient1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CmuMnu_Ingredient2 = new System.Windows.Forms.ToolStripMenuItem();
            this.CmuMnu_RemoveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel_Right = new System.Windows.Forms.Panel();
            this.DSP_Info = new DarkUI.Controls.DarkSectionPanel();
            this.panelIngredientInfo = new System.Windows.Forms.Panel();
            this.Table_IngredientInfo = new System.Windows.Forms.TableLayoutPanel();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.Label_Charisma = new DarkUI.Controls.DarkLabel();
            this.Label_Rarity = new DarkUI.Controls.DarkLabel();
            this.Label_Volume = new DarkUI.Controls.DarkLabel();
            this.Label_Appearance = new DarkUI.Controls.DarkLabel();
            this.Label_Aroma = new DarkUI.Controls.DarkLabel();
            this.Label_Texture = new DarkUI.Controls.DarkLabel();
            this.Label_Brain = new DarkUI.Controls.DarkLabel();
            this.Label_Health = new DarkUI.Controls.DarkLabel();
            this.Label_Rating = new DarkUI.Controls.DarkLabel();
            this.darkLabel14 = new DarkUI.Controls.DarkLabel();
            this.darkLabel12 = new DarkUI.Controls.DarkLabel();
            this.darkLabel10 = new DarkUI.Controls.DarkLabel();
            this.darkLabel8 = new DarkUI.Controls.DarkLabel();
            this.darkLabel6 = new DarkUI.Controls.DarkLabel();
            this.darkLabel3 = new DarkUI.Controls.DarkLabel();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.darkLabel5 = new DarkUI.Controls.DarkLabel();
            this.Panel_Left.SuspendLayout();
            this.DSP_Ingredients.SuspendLayout();
            this.Panel_AddRemove.SuspendLayout();
            this.Panel_RemoveIngredient.SuspendLayout();
            this.Panel_AddIngredient.SuspendLayout();
            this.DSP_Inventory.SuspendLayout();
            this.panelInventory.SuspendLayout();
            this.Cmu_Inventory.SuspendLayout();
            this.Panel_Right.SuspendLayout();
            this.DSP_Info.SuspendLayout();
            this.panelIngredientInfo.SuspendLayout();
            this.Table_IngredientInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Left
            // 
            this.Panel_Left.Controls.Add(this.DSP_Ingredients);
            this.Panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Left.Location = new System.Drawing.Point(0, 25);
            this.Panel_Left.Name = "Panel_Left";
            this.Panel_Left.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Panel_Left.Size = new System.Drawing.Size(177, 175);
            this.Panel_Left.TabIndex = 0;
            // 
            // DSP_Ingredients
            // 
            this.DSP_Ingredients.Controls.Add(this.Tree_Ingredients);
            this.DSP_Ingredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DSP_Ingredients.Location = new System.Drawing.Point(3, 3);
            this.DSP_Ingredients.Name = "DSP_Ingredients";
            this.DSP_Ingredients.SectionHeader = "Ingredient List";
            this.DSP_Ingredients.Size = new System.Drawing.Size(174, 172);
            this.DSP_Ingredients.TabIndex = 5;
            // 
            // Tree_Ingredients
            // 
            this.Tree_Ingredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tree_Ingredients.Location = new System.Drawing.Point(1, 25);
            this.Tree_Ingredients.MaxDragChange = 20;
            this.Tree_Ingredients.MultiSelect = true;
            this.Tree_Ingredients.Name = "Tree_Ingredients";
            this.Tree_Ingredients.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.Tree_Ingredients.Size = new System.Drawing.Size(172, 146);
            this.Tree_Ingredients.TabIndex = 2;
            this.Tree_Ingredients.DoubleClick += new System.EventHandler(this.Tree_Ingredients_DoubleClick);
            // 
            // Panel_AddRemove
            // 
            this.Panel_AddRemove.Controls.Add(this.Panel_AddRemove_Bottom);
            this.Panel_AddRemove.Controls.Add(this.Panel_RemoveIngredient);
            this.Panel_AddRemove.Controls.Add(this.Panel_AddIngredient);
            this.Panel_AddRemove.Controls.Add(this.Panel_AddRemove_Top);
            this.Panel_AddRemove.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_AddRemove.Location = new System.Drawing.Point(177, 25);
            this.Panel_AddRemove.Name = "Panel_AddRemove";
            this.Panel_AddRemove.Size = new System.Drawing.Size(79, 175);
            this.Panel_AddRemove.TabIndex = 6;
            // 
            // Panel_AddRemove_Bottom
            // 
            this.Panel_AddRemove_Bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_AddRemove_Bottom.Location = new System.Drawing.Point(0, 116);
            this.Panel_AddRemove_Bottom.Name = "Panel_AddRemove_Bottom";
            this.Panel_AddRemove_Bottom.Size = new System.Drawing.Size(79, 59);
            this.Panel_AddRemove_Bottom.TabIndex = 0;
            // 
            // Panel_RemoveIngredient
            // 
            this.Panel_RemoveIngredient.Controls.Add(this.Button_Remove);
            this.Panel_RemoveIngredient.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_RemoveIngredient.Location = new System.Drawing.Point(0, 83);
            this.Panel_RemoveIngredient.Name = "Panel_RemoveIngredient";
            this.Panel_RemoveIngredient.Padding = new System.Windows.Forms.Padding(5);
            this.Panel_RemoveIngredient.Size = new System.Drawing.Size(79, 33);
            this.Panel_RemoveIngredient.TabIndex = 2;
            // 
            // Button_Remove
            // 
            this.Button_Remove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Remove.Location = new System.Drawing.Point(5, 5);
            this.Button_Remove.Name = "Button_Remove";
            this.Button_Remove.Padding = new System.Windows.Forms.Padding(5);
            this.Button_Remove.Size = new System.Drawing.Size(69, 23);
            this.Button_Remove.TabIndex = 1;
            this.Button_Remove.Text = "< Remove";
            this.Button_Remove.Click += new System.EventHandler(this.Button_Remove_Click);
            // 
            // Panel_AddIngredient
            // 
            this.Panel_AddIngredient.Controls.Add(this.Button_Add);
            this.Panel_AddIngredient.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_AddIngredient.Location = new System.Drawing.Point(0, 50);
            this.Panel_AddIngredient.Name = "Panel_AddIngredient";
            this.Panel_AddIngredient.Padding = new System.Windows.Forms.Padding(5);
            this.Panel_AddIngredient.Size = new System.Drawing.Size(79, 33);
            this.Panel_AddIngredient.TabIndex = 1;
            // 
            // Button_Add
            // 
            this.Button_Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Add.Location = new System.Drawing.Point(5, 5);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Padding = new System.Windows.Forms.Padding(5);
            this.Button_Add.Size = new System.Drawing.Size(69, 23);
            this.Button_Add.TabIndex = 2;
            this.Button_Add.Text = "Add >";
            this.Button_Add.Click += new System.EventHandler(this.Button_AddToInventory_Click);
            // 
            // Panel_AddRemove_Top
            // 
            this.Panel_AddRemove_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_AddRemove_Top.Location = new System.Drawing.Point(0, 0);
            this.Panel_AddRemove_Top.Name = "Panel_AddRemove_Top";
            this.Panel_AddRemove_Top.Size = new System.Drawing.Size(79, 50);
            this.Panel_AddRemove_Top.TabIndex = 0;
            // 
            // DSP_Inventory
            // 
            this.DSP_Inventory.Controls.Add(this.panelInventory);
            this.DSP_Inventory.Dock = System.Windows.Forms.DockStyle.Left;
            this.DSP_Inventory.Location = new System.Drawing.Point(256, 25);
            this.DSP_Inventory.Name = "DSP_Inventory";
            this.DSP_Inventory.SectionHeader = "Inventory";
            this.DSP_Inventory.Size = new System.Drawing.Size(152, 175);
            this.DSP_Inventory.TabIndex = 7;
            // 
            // panelInventory
            // 
            this.panelInventory.Controls.Add(this.List_Inventory);
            this.panelInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInventory.Location = new System.Drawing.Point(1, 25);
            this.panelInventory.Name = "panelInventory";
            this.panelInventory.Size = new System.Drawing.Size(150, 149);
            this.panelInventory.TabIndex = 4;
            // 
            // List_Inventory
            // 
            this.List_Inventory.ContextMenuStrip = this.Cmu_Inventory;
            this.List_Inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List_Inventory.Location = new System.Drawing.Point(0, 0);
            this.List_Inventory.Name = "List_Inventory";
            this.List_Inventory.Size = new System.Drawing.Size(150, 149);
            this.List_Inventory.TabIndex = 1;
            this.List_Inventory.Text = "List_Inventory";
            this.List_Inventory.SelectedIndicesChanged += new System.EventHandler(this.List_Inventory_ShowInfo);
            this.List_Inventory.DoubleClick += new System.EventHandler(this.List_Inventory_DoubleClick);
            // 
            // Cmu_Inventory
            // 
            this.Cmu_Inventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.Cmu_Inventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Cmu_Inventory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmuMnu_Ingredient1,
            this.CmuMnu_Ingredient2,
            this.CmuMnu_RemoveAll});
            this.Cmu_Inventory.Name = "darkContextMenu1";
            this.Cmu_Inventory.Size = new System.Drawing.Size(181, 92);
            // 
            // CmuMnu_Ingredient1
            // 
            this.CmuMnu_Ingredient1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.CmuMnu_Ingredient1.Name = "CmuMnu_Ingredient1";
            this.CmuMnu_Ingredient1.Size = new System.Drawing.Size(180, 22);
            this.CmuMnu_Ingredient1.Text = "Make Ingredient &1";
            this.CmuMnu_Ingredient1.Click += new System.EventHandler(this.CmuMnu_Ingredient1_Click);
            // 
            // CmuMnu_Ingredient2
            // 
            this.CmuMnu_Ingredient2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.CmuMnu_Ingredient2.Name = "CmuMnu_Ingredient2";
            this.CmuMnu_Ingredient2.Size = new System.Drawing.Size(180, 22);
            this.CmuMnu_Ingredient2.Text = "Make Ingredient &2";
            this.CmuMnu_Ingredient2.Click += new System.EventHandler(this.CmuMnu_Ingredient2_Click);
            // 
            // CmuMnu_RemoveAll
            // 
            this.CmuMnu_RemoveAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.CmuMnu_RemoveAll.Name = "CmuMnu_RemoveAll";
            this.CmuMnu_RemoveAll.Size = new System.Drawing.Size(180, 22);
            this.CmuMnu_RemoveAll.Text = "&Remove All";
            this.CmuMnu_RemoveAll.Click += new System.EventHandler(this.CmuMnu_RemoveAll_Click);
            // 
            // Panel_Right
            // 
            this.Panel_Right.Controls.Add(this.DSP_Info);
            this.Panel_Right.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Right.Location = new System.Drawing.Point(408, 25);
            this.Panel_Right.Name = "Panel_Right";
            this.Panel_Right.Size = new System.Drawing.Size(146, 175);
            this.Panel_Right.TabIndex = 8;
            // 
            // DSP_Info
            // 
            this.DSP_Info.Controls.Add(this.panelIngredientInfo);
            this.DSP_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DSP_Info.Location = new System.Drawing.Point(0, 0);
            this.DSP_Info.Name = "DSP_Info";
            this.DSP_Info.SectionHeader = "Info";
            this.DSP_Info.Size = new System.Drawing.Size(146, 175);
            this.DSP_Info.TabIndex = 2;
            // 
            // panelIngredientInfo
            // 
            this.panelIngredientInfo.Controls.Add(this.Table_IngredientInfo);
            this.panelIngredientInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIngredientInfo.Location = new System.Drawing.Point(1, 25);
            this.panelIngredientInfo.Margin = new System.Windows.Forms.Padding(0);
            this.panelIngredientInfo.Name = "panelIngredientInfo";
            this.panelIngredientInfo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 7);
            this.panelIngredientInfo.Size = new System.Drawing.Size(144, 149);
            this.panelIngredientInfo.TabIndex = 1;
            // 
            // Table_IngredientInfo
            // 
            this.Table_IngredientInfo.ColumnCount = 2;
            this.Table_IngredientInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.16667F));
            this.Table_IngredientInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.83333F));
            this.Table_IngredientInfo.Controls.Add(this.darkLabel2, 0, 8);
            this.Table_IngredientInfo.Controls.Add(this.Label_Charisma, 1, 8);
            this.Table_IngredientInfo.Controls.Add(this.Label_Rarity, 1, 7);
            this.Table_IngredientInfo.Controls.Add(this.Label_Volume, 1, 6);
            this.Table_IngredientInfo.Controls.Add(this.Label_Appearance, 1, 5);
            this.Table_IngredientInfo.Controls.Add(this.Label_Aroma, 1, 4);
            this.Table_IngredientInfo.Controls.Add(this.Label_Texture, 1, 3);
            this.Table_IngredientInfo.Controls.Add(this.Label_Brain, 1, 2);
            this.Table_IngredientInfo.Controls.Add(this.Label_Health, 1, 1);
            this.Table_IngredientInfo.Controls.Add(this.Label_Rating, 1, 0);
            this.Table_IngredientInfo.Controls.Add(this.darkLabel14, 0, 7);
            this.Table_IngredientInfo.Controls.Add(this.darkLabel12, 0, 6);
            this.Table_IngredientInfo.Controls.Add(this.darkLabel10, 0, 5);
            this.Table_IngredientInfo.Controls.Add(this.darkLabel8, 0, 4);
            this.Table_IngredientInfo.Controls.Add(this.darkLabel6, 0, 3);
            this.Table_IngredientInfo.Controls.Add(this.darkLabel3, 0, 2);
            this.Table_IngredientInfo.Controls.Add(this.darkLabel1, 0, 1);
            this.Table_IngredientInfo.Controls.Add(this.darkLabel5, 0, 0);
            this.Table_IngredientInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Table_IngredientInfo.Location = new System.Drawing.Point(0, 5);
            this.Table_IngredientInfo.Name = "Table_IngredientInfo";
            this.Table_IngredientInfo.RowCount = 9;
            this.Table_IngredientInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Table_IngredientInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Table_IngredientInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Table_IngredientInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Table_IngredientInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Table_IngredientInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Table_IngredientInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Table_IngredientInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Table_IngredientInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Table_IngredientInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Table_IngredientInfo.Size = new System.Drawing.Size(144, 118);
            this.Table_IngredientInfo.TabIndex = 1;
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.darkLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(3, 104);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(55, 14);
            this.darkLabel2.TabIndex = 31;
            this.darkLabel2.Text = "Charisma";
            this.darkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Charisma
            // 
            this.Label_Charisma.AutoSize = true;
            this.Label_Charisma.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label_Charisma.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Charisma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Label_Charisma.Location = new System.Drawing.Point(81, 104);
            this.Label_Charisma.Name = "Label_Charisma";
            this.Label_Charisma.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Label_Charisma.Size = new System.Drawing.Size(35, 14);
            this.Label_Charisma.TabIndex = 30;
            this.Label_Charisma.Text = "N/A";
            this.Label_Charisma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Rarity
            // 
            this.Label_Rarity.AutoSize = true;
            this.Label_Rarity.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label_Rarity.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Rarity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Label_Rarity.Location = new System.Drawing.Point(81, 91);
            this.Label_Rarity.Name = "Label_Rarity";
            this.Label_Rarity.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Label_Rarity.Size = new System.Drawing.Size(35, 13);
            this.Label_Rarity.TabIndex = 29;
            this.Label_Rarity.Text = "N/A";
            this.Label_Rarity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Volume
            // 
            this.Label_Volume.AutoSize = true;
            this.Label_Volume.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label_Volume.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Volume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Label_Volume.Location = new System.Drawing.Point(81, 78);
            this.Label_Volume.Name = "Label_Volume";
            this.Label_Volume.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Label_Volume.Size = new System.Drawing.Size(35, 13);
            this.Label_Volume.TabIndex = 28;
            this.Label_Volume.Text = "N/A";
            this.Label_Volume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Appearance
            // 
            this.Label_Appearance.AutoSize = true;
            this.Label_Appearance.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label_Appearance.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Label_Appearance.Location = new System.Drawing.Point(81, 65);
            this.Label_Appearance.Name = "Label_Appearance";
            this.Label_Appearance.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Label_Appearance.Size = new System.Drawing.Size(35, 13);
            this.Label_Appearance.TabIndex = 27;
            this.Label_Appearance.Text = "N/A";
            this.Label_Appearance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Aroma
            // 
            this.Label_Aroma.AutoSize = true;
            this.Label_Aroma.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label_Aroma.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Aroma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Label_Aroma.Location = new System.Drawing.Point(81, 52);
            this.Label_Aroma.Name = "Label_Aroma";
            this.Label_Aroma.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Label_Aroma.Size = new System.Drawing.Size(35, 13);
            this.Label_Aroma.TabIndex = 26;
            this.Label_Aroma.Text = "N/A";
            this.Label_Aroma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Texture
            // 
            this.Label_Texture.AutoSize = true;
            this.Label_Texture.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label_Texture.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Texture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Label_Texture.Location = new System.Drawing.Point(81, 39);
            this.Label_Texture.Name = "Label_Texture";
            this.Label_Texture.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Label_Texture.Size = new System.Drawing.Size(35, 13);
            this.Label_Texture.TabIndex = 25;
            this.Label_Texture.Text = "N/A";
            this.Label_Texture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Brain
            // 
            this.Label_Brain.AutoSize = true;
            this.Label_Brain.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label_Brain.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Brain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Label_Brain.Location = new System.Drawing.Point(81, 26);
            this.Label_Brain.Name = "Label_Brain";
            this.Label_Brain.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Label_Brain.Size = new System.Drawing.Size(35, 13);
            this.Label_Brain.TabIndex = 24;
            this.Label_Brain.Text = "N/A";
            this.Label_Brain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Health
            // 
            this.Label_Health.AutoSize = true;
            this.Label_Health.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label_Health.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Health.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Label_Health.Location = new System.Drawing.Point(81, 13);
            this.Label_Health.Name = "Label_Health";
            this.Label_Health.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Label_Health.Size = new System.Drawing.Size(35, 13);
            this.Label_Health.TabIndex = 23;
            this.Label_Health.Text = "N/A";
            this.Label_Health.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Rating
            // 
            this.Label_Rating.AutoSize = true;
            this.Label_Rating.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label_Rating.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Rating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Label_Rating.Location = new System.Drawing.Point(81, 0);
            this.Label_Rating.Name = "Label_Rating";
            this.Label_Rating.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Label_Rating.Size = new System.Drawing.Size(35, 13);
            this.Label_Rating.TabIndex = 22;
            this.Label_Rating.Text = "N/A";
            this.Label_Rating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // darkLabel14
            // 
            this.darkLabel14.AutoSize = true;
            this.darkLabel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.darkLabel14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel14.Location = new System.Drawing.Point(3, 91);
            this.darkLabel14.Name = "darkLabel14";
            this.darkLabel14.Size = new System.Drawing.Size(37, 13);
            this.darkLabel14.TabIndex = 19;
            this.darkLabel14.Text = "Rarity";
            this.darkLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // darkLabel12
            // 
            this.darkLabel12.AutoSize = true;
            this.darkLabel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.darkLabel12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel12.Location = new System.Drawing.Point(3, 78);
            this.darkLabel12.Name = "darkLabel12";
            this.darkLabel12.Size = new System.Drawing.Size(46, 13);
            this.darkLabel12.TabIndex = 17;
            this.darkLabel12.Text = "Volume";
            this.darkLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // darkLabel10
            // 
            this.darkLabel10.AutoSize = true;
            this.darkLabel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.darkLabel10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel10.Location = new System.Drawing.Point(3, 65);
            this.darkLabel10.Name = "darkLabel10";
            this.darkLabel10.Size = new System.Drawing.Size(69, 13);
            this.darkLabel10.TabIndex = 15;
            this.darkLabel10.Text = "Appearance";
            this.darkLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // darkLabel8
            // 
            this.darkLabel8.AutoSize = true;
            this.darkLabel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.darkLabel8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel8.Location = new System.Drawing.Point(3, 52);
            this.darkLabel8.Name = "darkLabel8";
            this.darkLabel8.Size = new System.Drawing.Size(42, 13);
            this.darkLabel8.TabIndex = 13;
            this.darkLabel8.Text = "Aroma";
            this.darkLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // darkLabel6
            // 
            this.darkLabel6.AutoSize = true;
            this.darkLabel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.darkLabel6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel6.Location = new System.Drawing.Point(3, 39);
            this.darkLabel6.Name = "darkLabel6";
            this.darkLabel6.Size = new System.Drawing.Size(45, 13);
            this.darkLabel6.TabIndex = 11;
            this.darkLabel6.Text = "Texture";
            this.darkLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // darkLabel3
            // 
            this.darkLabel3.AutoSize = true;
            this.darkLabel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.darkLabel3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel3.Location = new System.Drawing.Point(3, 26);
            this.darkLabel3.Name = "darkLabel3";
            this.darkLabel3.Size = new System.Drawing.Size(34, 13);
            this.darkLabel3.TabIndex = 9;
            this.darkLabel3.Text = "Brain";
            this.darkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.darkLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(3, 13);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(41, 13);
            this.darkLabel1.TabIndex = 7;
            this.darkLabel1.Text = "Health";
            this.darkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // darkLabel5
            // 
            this.darkLabel5.AutoSize = true;
            this.darkLabel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.darkLabel5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel5.Location = new System.Drawing.Point(3, 0);
            this.darkLabel5.Name = "darkLabel5";
            this.darkLabel5.Size = new System.Drawing.Size(41, 13);
            this.darkLabel5.TabIndex = 5;
            this.darkLabel5.Text = "Rating";
            this.darkLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dock_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.Panel_Right);
            this.Controls.Add(this.DSP_Inventory);
            this.Controls.Add(this.Panel_AddRemove);
            this.Controls.Add(this.Panel_Left);
            this.DefaultDockArea = DarkUI.Docking.DarkDockArea.Bottom;
            this.DockText = "Ingredient Manager";
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Icon = global::NipponAdvisor.GameIcons.ingredient_16x;
            this.Name = "Dock_Inventory";
            this.Size = new System.Drawing.Size(554, 200);
            this.Panel_Left.ResumeLayout(false);
            this.DSP_Ingredients.ResumeLayout(false);
            this.Panel_AddRemove.ResumeLayout(false);
            this.Panel_RemoveIngredient.ResumeLayout(false);
            this.Panel_AddIngredient.ResumeLayout(false);
            this.DSP_Inventory.ResumeLayout(false);
            this.panelInventory.ResumeLayout(false);
            this.Cmu_Inventory.ResumeLayout(false);
            this.Panel_Right.ResumeLayout(false);
            this.DSP_Info.ResumeLayout(false);
            this.panelIngredientInfo.ResumeLayout(false);
            this.Table_IngredientInfo.ResumeLayout(false);
            this.Table_IngredientInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Left;
        private DarkUI.Controls.DarkSectionPanel DSP_Ingredients;
        private System.Windows.Forms.Panel Panel_AddRemove;
        private System.Windows.Forms.Panel Panel_AddRemove_Bottom;
        private System.Windows.Forms.Panel Panel_RemoveIngredient;
        private DarkUI.Controls.DarkButton Button_Remove;
        private System.Windows.Forms.Panel Panel_AddIngredient;
        private DarkUI.Controls.DarkButton Button_Add;
        private System.Windows.Forms.Panel Panel_AddRemove_Top;
        private DarkUI.Controls.DarkSectionPanel DSP_Inventory;
        private System.Windows.Forms.Panel panelInventory;
        private DarkUI.Controls.DarkListView List_Inventory;
        private DarkUI.Controls.DarkTreeView Tree_Ingredients;
        private System.Windows.Forms.Panel Panel_Right;
        private DarkUI.Controls.DarkSectionPanel DSP_Info;
        private System.Windows.Forms.Panel panelIngredientInfo;
        private System.Windows.Forms.TableLayoutPanel Table_IngredientInfo;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkLabel Label_Charisma;
        private DarkUI.Controls.DarkLabel Label_Rarity;
        private DarkUI.Controls.DarkLabel Label_Volume;
        private DarkUI.Controls.DarkLabel Label_Appearance;
        private DarkUI.Controls.DarkLabel Label_Aroma;
        private DarkUI.Controls.DarkLabel Label_Texture;
        private DarkUI.Controls.DarkLabel Label_Brain;
        private DarkUI.Controls.DarkLabel Label_Health;
        private DarkUI.Controls.DarkLabel Label_Rating;
        private DarkUI.Controls.DarkLabel darkLabel14;
        private DarkUI.Controls.DarkLabel darkLabel12;
        private DarkUI.Controls.DarkLabel darkLabel10;
        private DarkUI.Controls.DarkLabel darkLabel8;
        private DarkUI.Controls.DarkLabel darkLabel6;
        private DarkUI.Controls.DarkLabel darkLabel3;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkLabel darkLabel5;
        private DarkUI.Controls.DarkContextMenu Cmu_Inventory;
        private System.Windows.Forms.ToolStripMenuItem CmuMnu_Ingredient1;
        private System.Windows.Forms.ToolStripMenuItem CmuMnu_Ingredient2;
        private System.Windows.Forms.ToolStripMenuItem CmuMnu_RemoveAll;
    }
}
