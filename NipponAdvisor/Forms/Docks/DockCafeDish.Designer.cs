namespace NipponAdvisor.Forms.Docks
{
    partial class DockCafeDish
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
            this.panelTopLeft = new System.Windows.Forms.Panel();
            this.textName = new DarkUI.Controls.DarkTextBox();
            this.titleName = new DarkUI.Controls.DarkTitle();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelBottomLeft = new System.Windows.Forms.Panel();
            this.slideStars = new System.Windows.Forms.TrackBar();
            this.titleStars = new DarkUI.Controls.DarkTitle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconHealth = new System.Windows.Forms.PictureBox();
            this.darkTextBox1 = new DarkUI.Controls.DarkTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panelTopLeft.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelBottomLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideStars)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopLeft
            // 
            this.panelTopLeft.Controls.Add(this.textName);
            this.panelTopLeft.Controls.Add(this.titleName);
            this.panelTopLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopLeft.Location = new System.Drawing.Point(0, 0);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Size = new System.Drawing.Size(150, 62);
            this.panelTopLeft.TabIndex = 0;
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textName.Location = new System.Drawing.Point(0, 15);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(150, 23);
            this.textName.TabIndex = 5;
            // 
            // titleName
            // 
            this.titleName.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleName.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.titleName.Location = new System.Drawing.Point(0, 0);
            this.titleName.Name = "titleName";
            this.titleName.Size = new System.Drawing.Size(150, 15);
            this.titleName.TabIndex = 4;
            this.titleName.Text = "Dish Name";
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.panelBottomLeft);
            this.panelLeft.Controls.Add(this.panelTopLeft);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(150, 129);
            this.panelLeft.TabIndex = 1;
            // 
            // panelBottomLeft
            // 
            this.panelBottomLeft.Controls.Add(this.slideStars);
            this.panelBottomLeft.Controls.Add(this.titleStars);
            this.panelBottomLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomLeft.Location = new System.Drawing.Point(0, 65);
            this.panelBottomLeft.Name = "panelBottomLeft";
            this.panelBottomLeft.Size = new System.Drawing.Size(150, 64);
            this.panelBottomLeft.TabIndex = 2;
            // 
            // slideStars
            // 
            this.slideStars.Dock = System.Windows.Forms.DockStyle.Top;
            this.slideStars.LargeChange = 3;
            this.slideStars.Location = new System.Drawing.Point(0, 13);
            this.slideStars.Maximum = 9;
            this.slideStars.Minimum = 1;
            this.slideStars.Name = "slideStars";
            this.slideStars.Size = new System.Drawing.Size(150, 45);
            this.slideStars.TabIndex = 9;
            this.slideStars.Value = 1;
            // 
            // titleStars
            // 
            this.titleStars.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleStars.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.titleStars.Location = new System.Drawing.Point(0, 0);
            this.titleStars.Name = "titleStars";
            this.titleStars.Size = new System.Drawing.Size(150, 13);
            this.titleStars.TabIndex = 8;
            this.titleStars.Text = "Stars";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.panelRight);
            this.pnlMain.Controls.Add(this.panelLeft);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 25);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(399, 129);
            this.pnlMain.TabIndex = 2;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.tableLayoutPanel1);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRight.Location = new System.Drawing.Point(150, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelRight.Size = new System.Drawing.Size(385, 129);
            this.panelRight.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.iconHealth, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.darkTextBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox7, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(148, 129);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::NipponAdvisor.GameIcons.Appearance_24x;
            this.pictureBox1.Location = new System.Drawing.Point(84, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 25);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // iconHealth
            // 
            this.iconHealth.Image = global::NipponAdvisor.GameIcons.Health_24x;
            this.iconHealth.Location = new System.Drawing.Point(3, 3);
            this.iconHealth.Name = "iconHealth";
            this.iconHealth.Size = new System.Drawing.Size(24, 24);
            this.iconHealth.TabIndex = 1;
            this.iconHealth.TabStop = false;
            // 
            // darkTextBox1
            // 
            this.darkTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextBox1.Location = new System.Drawing.Point(40, 3);
            this.darkTextBox1.Name = "darkTextBox1";
            this.darkTextBox1.Size = new System.Drawing.Size(31, 23);
            this.darkTextBox1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(84, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 25);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Location = new System.Drawing.Point(84, 67);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 25);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Location = new System.Drawing.Point(84, 99);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 25);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::NipponAdvisor.GameIcons.Brain_24x;
            this.pictureBox5.Location = new System.Drawing.Point(3, 35);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::NipponAdvisor.GameIcons.Texture_24x;
            this.pictureBox6.Location = new System.Drawing.Point(3, 67);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 24);
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::NipponAdvisor.GameIcons.Aroma_24x;
            this.pictureBox7.Location = new System.Drawing.Point(3, 99);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(24, 24);
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            // 
            // DockCafeDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.DockText = "Develop Dish";
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "DockCafeDish";
            this.Size = new System.Drawing.Size(399, 154);
            this.Load += new System.EventHandler(this.DockCafeDish_Load);
            this.panelTopLeft.ResumeLayout(false);
            this.panelTopLeft.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelBottomLeft.ResumeLayout(false);
            this.panelBottomLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideStars)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopLeft;
        private DarkUI.Controls.DarkTextBox textName;
        private DarkUI.Controls.DarkTitle titleName;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelBottomLeft;
        private System.Windows.Forms.TrackBar slideStars;
        private DarkUI.Controls.DarkTitle titleStars;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox iconHealth;
        private DarkUI.Controls.DarkTextBox darkTextBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}
