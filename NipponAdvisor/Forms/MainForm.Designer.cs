using DarkUI.Docking;

namespace NipponAdvisor.Forms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.stripMain = new DarkUI.Controls.DarkStatusStrip();
            this.LabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuMain = new DarkUI.Controls.DarkMenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewDish = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSaveDish = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.checkableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkableWithIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.checkedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedWithIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDish = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIngredients = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.darkSeparator1 = new DarkUI.Controls.DarkSeparator();
            this.DockPanel = new DarkUI.Docking.DarkDockPanel();
            this.stripMain.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // stripMain
            // 
            this.stripMain.AutoSize = false;
            this.stripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.stripMain.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.stripMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.stripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelStatus,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel5});
            this.stripMain.Location = new System.Drawing.Point(0, 354);
            this.stripMain.Name = "stripMain";
            this.stripMain.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.stripMain.Size = new System.Drawing.Size(785, 24);
            this.stripMain.SizingGrip = false;
            this.stripMain.TabIndex = 3;
            this.stripMain.Text = "darkStatusStrip1";
            // 
            // LabelStatus
            // 
            this.LabelStatus.Margin = new System.Windows.Forms.Padding(1, 0, 50, 0);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(38, 16);
            this.LabelStatus.Text = "Ready";
            this.LabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Margin = new System.Windows.Forms.Padding(0, 0, 50, 2);
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(600, 14);
            this.toolStripStatusLabel6.Spring = true;
            this.toolStripStatusLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(45, 16);
            this.toolStripStatusLabel5.Text = "120 MB";
            this.toolStripStatusLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.mnuMain.BackgroundImage = global::NipponAdvisor.AppIcons.DarkGrayBg;
            this.mnuMain.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.mnuMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuView,
            this.mnuTools,
            this.mnuWindow,
            this.mnuHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.mnuMain.Size = new System.Drawing.Size(785, 24);
            this.mnuMain.TabIndex = 5;
            this.mnuMain.Text = "darkMenuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewDish,
            this.toolStripSeparator1,
            this.mnuSaveDish,
            this.mnuClose});
            this.mnuFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuNewDish
            // 
            this.mnuNewDish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.mnuNewDish.Name = "mnuNewDish";
            this.mnuNewDish.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuNewDish.Size = new System.Drawing.Size(164, 22);
            this.mnuNewDish.Text = "&New Dish";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // mnuSaveDish
            // 
            this.mnuSaveDish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.mnuSaveDish.Name = "mnuSaveDish";
            this.mnuSaveDish.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSaveDish.Size = new System.Drawing.Size(164, 22);
            this.mnuSaveDish.Text = "Save Dish";
            // 
            // mnuClose
            // 
            this.mnuClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuClose.Size = new System.Drawing.Size(164, 22);
            this.mnuClose.Text = "E&xit";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDialog});
            this.mnuView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(44, 20);
            this.mnuView.Text = "&View";
            // 
            // mnuDialog
            // 
            this.mnuDialog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.mnuDialog.Name = "mnuDialog";
            this.mnuDialog.Size = new System.Drawing.Size(130, 22);
            this.mnuDialog.Text = "&Dialog test";
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkableToolStripMenuItem,
            this.checkableWithIconToolStripMenuItem,
            this.toolStripSeparator2,
            this.checkedToolStripMenuItem,
            this.checkedWithIconToolStripMenuItem});
            this.mnuTools.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(45, 20);
            this.mnuTools.Text = "&Tools";
            // 
            // checkableToolStripMenuItem
            // 
            this.checkableToolStripMenuItem.CheckOnClick = true;
            this.checkableToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.checkableToolStripMenuItem.Name = "checkableToolStripMenuItem";
            this.checkableToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.checkableToolStripMenuItem.Text = "Checkable";
            // 
            // checkableWithIconToolStripMenuItem
            // 
            this.checkableWithIconToolStripMenuItem.CheckOnClick = true;
            this.checkableWithIconToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.checkableWithIconToolStripMenuItem.Name = "checkableWithIconToolStripMenuItem";
            this.checkableWithIconToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.checkableWithIconToolStripMenuItem.Text = "Checkable with icon";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(175, 6);
            // 
            // checkedToolStripMenuItem
            // 
            this.checkedToolStripMenuItem.Checked = true;
            this.checkedToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkedToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.checkedToolStripMenuItem.Name = "checkedToolStripMenuItem";
            this.checkedToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.checkedToolStripMenuItem.Text = "Checked";
            // 
            // checkedWithIconToolStripMenuItem
            // 
            this.checkedWithIconToolStripMenuItem.Checked = true;
            this.checkedWithIconToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkedWithIconToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.checkedWithIconToolStripMenuItem.Name = "checkedWithIconToolStripMenuItem";
            this.checkedWithIconToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.checkedWithIconToolStripMenuItem.Text = "Checked with icon";
            // 
            // mnuWindow
            // 
            this.mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDish,
            this.mnuIngredients});
            this.mnuWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Size = new System.Drawing.Size(63, 20);
            this.mnuWindow.Text = "&Window";
            // 
            // mnuDish
            // 
            this.mnuDish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.mnuDish.Name = "mnuDish";
            this.mnuDish.Size = new System.Drawing.Size(133, 22);
            this.mnuDish.Text = "&Dish Info";
            // 
            // mnuIngredients
            // 
            this.mnuIngredients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.mnuIngredients.Name = "mnuIngredients";
            this.mnuIngredients.Size = new System.Drawing.Size(133, 22);
            this.mnuIngredients.Text = "&Ingredients";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(43, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(144, 22);
            this.mnuAbout.Text = "&About DarkUI";
            // 
            // darkSeparator1
            // 
            this.darkSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.darkSeparator1.Location = new System.Drawing.Point(0, 24);
            this.darkSeparator1.Name = "darkSeparator1";
            this.darkSeparator1.Size = new System.Drawing.Size(785, 2);
            this.darkSeparator1.TabIndex = 7;
            this.darkSeparator1.Text = "darkSeparator1";
            // 
            // DockPanel
            // 
            this.DockPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.DockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DockPanel.Location = new System.Drawing.Point(0, 26);
            this.DockPanel.Name = "DockPanel";
            this.DockPanel.Size = new System.Drawing.Size(785, 328);
            this.DockPanel.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 378);
            this.Controls.Add(this.DockPanel);
            this.Controls.Add(this.darkSeparator1);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.stripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Cafe Nippon Buddy!";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.stripMain.ResumeLayout(false);
            this.stripMain.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DarkUI.Controls.DarkStatusStrip stripMain;
        private System.Windows.Forms.ToolStripStatusLabel LabelStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private DarkUI.Controls.DarkMenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNewDish;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuDialog;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem checkableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkableWithIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem checkedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkedWithIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuDish;
        private System.Windows.Forms.ToolStripMenuItem mnuIngredients;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private DarkUI.Controls.DarkSeparator darkSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveDish;
        private DarkDockPanel DockPanel;
    }
}