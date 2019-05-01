using NipponAdvisor.DarkUIExt;

namespace NipponAdvisor.Forms.Docks
{
    partial class DockDish
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
            this.tblLayoutDishInfo = new System.Windows.Forms.TableLayoutPanel();
            this.titleRating = new DarkUI.Controls.DarkTitle();
            this.titleDishName = new DarkUI.Controls.DarkTitle();
            this.ComboBaseDish = new System.Windows.Forms.ComboBox();
            this.textDishName = new DarkUI.Controls.DarkTextBox();
            this.tblLayoutRating = new System.Windows.Forms.TableLayoutPanel();
            this.labelRating = new DarkUI.Controls.DarkLabel();
            this.imgRating = new System.Windows.Forms.PictureBox();
            this.sliderRating = new System.Windows.Forms.TrackBar();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.tblLayoutStats = new System.Windows.Forms.TableLayoutPanel();
            this.textCharisma = new DarkUI.Controls.DarkTextBox();
            this.textAroma = new DarkUI.Controls.DarkTextBox();
            this.textRarity = new DarkUI.Controls.DarkTextBox();
            this.textTexture = new DarkUI.Controls.DarkTextBox();
            this.textVolume = new DarkUI.Controls.DarkTextBox();
            this.textBrain = new DarkUI.Controls.DarkTextBox();
            this.textAppearance = new DarkUI.Controls.DarkTextBox();
            this.imgAppearance = new System.Windows.Forms.PictureBox();
            this.imgHealth = new System.Windows.Forms.PictureBox();
            this.textHealth = new DarkUI.Controls.DarkTextBox();
            this.imgRarity = new System.Windows.Forms.PictureBox();
            this.imgVolume = new System.Windows.Forms.PictureBox();
            this.imgCharisma = new System.Windows.Forms.PictureBox();
            this.imgTexture = new System.Windows.Forms.PictureBox();
            this.imgAroma = new System.Windows.Forms.PictureBox();
            this.imgBrain = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.tblLayoutDishInfo.SuspendLayout();
            this.tblLayoutRating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderRating)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.tblLayoutStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAppearance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRarity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCharisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTexture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAroma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBrain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.tblLayoutDishInfo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 25);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(10);
            this.panelTop.Size = new System.Drawing.Size(204, 158);
            this.panelTop.TabIndex = 0;
            // 
            // tblLayoutDishInfo
            // 
            this.tblLayoutDishInfo.ColumnCount = 1;
            this.tblLayoutDishInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLayoutDishInfo.Controls.Add(this.titleRating, 0, 4);
            this.tblLayoutDishInfo.Controls.Add(this.titleDishName, 0, 0);
            this.tblLayoutDishInfo.Controls.Add(this.ComboBaseDish, 0, 1);
            this.tblLayoutDishInfo.Controls.Add(this.textDishName, 0, 2);
            this.tblLayoutDishInfo.Controls.Add(this.tblLayoutRating, 0, 5);
            this.tblLayoutDishInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblLayoutDishInfo.Location = new System.Drawing.Point(10, 10);
            this.tblLayoutDishInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tblLayoutDishInfo.Name = "tblLayoutDishInfo";
            this.tblLayoutDishInfo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.tblLayoutDishInfo.RowCount = 6;
            this.tblLayoutDishInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutDishInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutDishInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutDishInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutDishInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutDishInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutDishInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutDishInfo.Size = new System.Drawing.Size(184, 146);
            this.tblLayoutDishInfo.TabIndex = 0;
            // 
            // titleRating
            // 
            this.titleRating.Dock = System.Windows.Forms.DockStyle.Left;
            this.titleRating.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.titleRating.Location = new System.Drawing.Point(0, 86);
            this.titleRating.Margin = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.titleRating.Name = "titleRating";
            this.titleRating.Size = new System.Drawing.Size(184, 15);
            this.titleRating.TabIndex = 12;
            this.titleRating.Text = "Dish Rating";
            // 
            // titleDishName
            // 
            this.titleDishName.Dock = System.Windows.Forms.DockStyle.Left;
            this.titleDishName.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.titleDishName.Location = new System.Drawing.Point(0, 5);
            this.titleDishName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.titleDishName.Name = "titleDishName";
            this.titleDishName.Size = new System.Drawing.Size(184, 15);
            this.titleDishName.TabIndex = 9;
            this.titleDishName.Text = "Dish Name / Base Dish";
            // 
            // ComboBaseDish
            // 
            this.ComboBaseDish.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBaseDish.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBaseDish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.ComboBaseDish.Dock = System.Windows.Forms.DockStyle.Left;
            this.ComboBaseDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBaseDish.ForeColor = System.Drawing.Color.Gainsboro;
            this.ComboBaseDish.FormattingEnabled = true;
            this.ComboBaseDish.Location = new System.Drawing.Point(0, 25);
            this.ComboBaseDish.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.ComboBaseDish.Name = "ComboBaseDish";
            this.ComboBaseDish.Size = new System.Drawing.Size(164, 23);
            this.ComboBaseDish.TabIndex = 1;
            this.ComboBaseDish.Text = "Base Dish";
            this.ComboBaseDish.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBaseDish_Validating);
            this.ComboBaseDish.Validated += new System.EventHandler(this.ComboBaseDish_Validated);
            // 
            // textDishName
            // 
            this.textDishName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textDishName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDishName.Dock = System.Windows.Forms.DockStyle.Left;
            this.textDishName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textDishName.Location = new System.Drawing.Point(0, 53);
            this.textDishName.Margin = new System.Windows.Forms.Padding(0);
            this.textDishName.Name = "textDishName";
            this.textDishName.Size = new System.Drawing.Size(164, 23);
            this.textDishName.TabIndex = 2;
            this.textDishName.Text = "Nickname";
            // 
            // tblLayoutRating
            // 
            this.tblLayoutRating.AutoSize = true;
            this.tblLayoutRating.ColumnCount = 3;
            this.tblLayoutRating.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.53061F));
            this.tblLayoutRating.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.30612F));
            this.tblLayoutRating.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.163265F));
            this.tblLayoutRating.Controls.Add(this.labelRating, 2, 0);
            this.tblLayoutRating.Controls.Add(this.imgRating, 1, 0);
            this.tblLayoutRating.Controls.Add(this.sliderRating, 0, 0);
            this.tblLayoutRating.Dock = System.Windows.Forms.DockStyle.Left;
            this.tblLayoutRating.Location = new System.Drawing.Point(0, 106);
            this.tblLayoutRating.Margin = new System.Windows.Forms.Padding(0);
            this.tblLayoutRating.Name = "tblLayoutRating";
            this.tblLayoutRating.RowCount = 1;
            this.tblLayoutRating.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutRating.Size = new System.Drawing.Size(184, 45);
            this.tblLayoutRating.TabIndex = 11;
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelRating.Location = new System.Drawing.Point(168, 0);
            this.labelRating.Margin = new System.Windows.Forms.Padding(0);
            this.labelRating.Name = "labelRating";
            this.labelRating.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.labelRating.Size = new System.Drawing.Size(15, 23);
            this.labelRating.TabIndex = 13;
            this.labelRating.Text = "1";
            // 
            // imgRating
            // 
            this.imgRating.Dock = System.Windows.Forms.DockStyle.Left;
            this.imgRating.Image = global::NipponAdvisor.GameIcons.Star_24x;
            this.imgRating.Location = new System.Drawing.Point(140, 0);
            this.imgRating.Margin = new System.Windows.Forms.Padding(0);
            this.imgRating.Name = "imgRating";
            this.imgRating.Size = new System.Drawing.Size(24, 45);
            this.imgRating.TabIndex = 12;
            this.imgRating.TabStop = false;
            // 
            // sliderRating
            // 
            this.sliderRating.Dock = System.Windows.Forms.DockStyle.Left;
            this.sliderRating.LargeChange = 3;
            this.sliderRating.Location = new System.Drawing.Point(0, 0);
            this.sliderRating.Margin = new System.Windows.Forms.Padding(0);
            this.sliderRating.Maximum = 9;
            this.sliderRating.Minimum = 1;
            this.sliderRating.Name = "sliderRating";
            this.sliderRating.Size = new System.Drawing.Size(132, 45);
            this.sliderRating.TabIndex = 3;
            this.sliderRating.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderRating.Value = 1;
            this.sliderRating.ValueChanged += new System.EventHandler(this.Rating_Changed);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.tblLayoutStats);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBottom.Location = new System.Drawing.Point(0, 183);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(10);
            this.panelBottom.Size = new System.Drawing.Size(204, 147);
            this.panelBottom.TabIndex = 1;
            // 
            // tblLayoutStats
            // 
            this.tblLayoutStats.ColumnCount = 4;
            this.tblLayoutStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblLayoutStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblLayoutStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutStats.Controls.Add(this.textCharisma, 3, 3);
            this.tblLayoutStats.Controls.Add(this.textAroma, 1, 3);
            this.tblLayoutStats.Controls.Add(this.textRarity, 3, 2);
            this.tblLayoutStats.Controls.Add(this.textTexture, 1, 2);
            this.tblLayoutStats.Controls.Add(this.textVolume, 3, 1);
            this.tblLayoutStats.Controls.Add(this.textBrain, 1, 1);
            this.tblLayoutStats.Controls.Add(this.textAppearance, 3, 0);
            this.tblLayoutStats.Controls.Add(this.imgAppearance, 2, 0);
            this.tblLayoutStats.Controls.Add(this.imgHealth, 0, 0);
            this.tblLayoutStats.Controls.Add(this.textHealth, 1, 0);
            this.tblLayoutStats.Controls.Add(this.imgRarity, 2, 2);
            this.tblLayoutStats.Controls.Add(this.imgVolume, 2, 1);
            this.tblLayoutStats.Controls.Add(this.imgCharisma, 2, 3);
            this.tblLayoutStats.Controls.Add(this.imgTexture, 0, 2);
            this.tblLayoutStats.Controls.Add(this.imgAroma, 0, 3);
            this.tblLayoutStats.Controls.Add(this.imgBrain, 0, 1);
            this.tblLayoutStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblLayoutStats.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tblLayoutStats.Location = new System.Drawing.Point(10, 10);
            this.tblLayoutStats.Name = "tblLayoutStats";
            this.tblLayoutStats.RowCount = 4;
            this.tblLayoutStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutStats.Size = new System.Drawing.Size(184, 124);
            this.tblLayoutStats.TabIndex = 0;
            // 
            // textCharisma
            // 
            this.textCharisma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCharisma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textCharisma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCharisma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textCharisma.Location = new System.Drawing.Point(125, 96);
            this.textCharisma.Name = "textCharisma";
            this.textCharisma.Size = new System.Drawing.Size(56, 23);
            this.textCharisma.TabIndex = 11;
            // 
            // textAroma
            // 
            this.textAroma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textAroma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textAroma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textAroma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textAroma.Location = new System.Drawing.Point(33, 96);
            this.textAroma.Name = "textAroma";
            this.textAroma.Size = new System.Drawing.Size(56, 23);
            this.textAroma.TabIndex = 7;
            // 
            // textRarity
            // 
            this.textRarity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textRarity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textRarity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textRarity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textRarity.Location = new System.Drawing.Point(125, 65);
            this.textRarity.Name = "textRarity";
            this.textRarity.Size = new System.Drawing.Size(56, 23);
            this.textRarity.TabIndex = 10;
            // 
            // textTexture
            // 
            this.textTexture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTexture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textTexture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTexture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textTexture.Location = new System.Drawing.Point(33, 65);
            this.textTexture.Name = "textTexture";
            this.textTexture.Size = new System.Drawing.Size(56, 23);
            this.textTexture.TabIndex = 6;
            // 
            // textVolume
            // 
            this.textVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textVolume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textVolume.Location = new System.Drawing.Point(125, 34);
            this.textVolume.Name = "textVolume";
            this.textVolume.Size = new System.Drawing.Size(56, 23);
            this.textVolume.TabIndex = 9;
            // 
            // textBrain
            // 
            this.textBrain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBrain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBrain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBrain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBrain.Location = new System.Drawing.Point(33, 34);
            this.textBrain.Name = "textBrain";
            this.textBrain.Size = new System.Drawing.Size(56, 23);
            this.textBrain.TabIndex = 5;
            // 
            // textAppearance
            // 
            this.textAppearance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textAppearance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textAppearance.Location = new System.Drawing.Point(125, 3);
            this.textAppearance.Name = "textAppearance";
            this.textAppearance.Size = new System.Drawing.Size(56, 23);
            this.textAppearance.TabIndex = 8;
            // 
            // imgAppearance
            // 
            this.imgAppearance.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgAppearance.Image = global::NipponAdvisor.GameIcons.Appearance_24x;
            this.imgAppearance.Location = new System.Drawing.Point(95, 3);
            this.imgAppearance.Name = "imgAppearance";
            this.imgAppearance.Size = new System.Drawing.Size(24, 25);
            this.imgAppearance.TabIndex = 4;
            this.imgAppearance.TabStop = false;
            // 
            // imgHealth
            // 
            this.imgHealth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgHealth.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgHealth.Image = global::NipponAdvisor.GameIcons.Health_24x;
            this.imgHealth.Location = new System.Drawing.Point(3, 3);
            this.imgHealth.Name = "imgHealth";
            this.imgHealth.Size = new System.Drawing.Size(24, 25);
            this.imgHealth.TabIndex = 0;
            this.imgHealth.TabStop = false;
            // 
            // textHealth
            // 
            this.textHealth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textHealth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textHealth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textHealth.Location = new System.Drawing.Point(33, 3);
            this.textHealth.Name = "textHealth";
            this.textHealth.Size = new System.Drawing.Size(56, 23);
            this.textHealth.TabIndex = 4;
            // 
            // imgRarity
            // 
            this.imgRarity.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgRarity.Image = global::NipponAdvisor.GameIcons.Rarity_24x;
            this.imgRarity.Location = new System.Drawing.Point(95, 65);
            this.imgRarity.Name = "imgRarity";
            this.imgRarity.Size = new System.Drawing.Size(24, 25);
            this.imgRarity.TabIndex = 3;
            this.imgRarity.TabStop = false;
            // 
            // imgVolume
            // 
            this.imgVolume.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgVolume.Image = global::NipponAdvisor.GameIcons.Volume_24x;
            this.imgVolume.Location = new System.Drawing.Point(95, 34);
            this.imgVolume.Name = "imgVolume";
            this.imgVolume.Size = new System.Drawing.Size(24, 25);
            this.imgVolume.TabIndex = 2;
            this.imgVolume.TabStop = false;
            // 
            // imgCharisma
            // 
            this.imgCharisma.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgCharisma.Image = global::NipponAdvisor.GameIcons.Charisma_24x;
            this.imgCharisma.Location = new System.Drawing.Point(95, 96);
            this.imgCharisma.Name = "imgCharisma";
            this.imgCharisma.Size = new System.Drawing.Size(24, 25);
            this.imgCharisma.TabIndex = 6;
            this.imgCharisma.TabStop = false;
            // 
            // imgTexture
            // 
            this.imgTexture.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgTexture.Image = global::NipponAdvisor.GameIcons.Texture_24x;
            this.imgTexture.Location = new System.Drawing.Point(3, 65);
            this.imgTexture.Name = "imgTexture";
            this.imgTexture.Size = new System.Drawing.Size(24, 25);
            this.imgTexture.TabIndex = 7;
            this.imgTexture.TabStop = false;
            // 
            // imgAroma
            // 
            this.imgAroma.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgAroma.Image = global::NipponAdvisor.GameIcons.Aroma_24x;
            this.imgAroma.Location = new System.Drawing.Point(3, 96);
            this.imgAroma.Name = "imgAroma";
            this.imgAroma.Size = new System.Drawing.Size(24, 25);
            this.imgAroma.TabIndex = 8;
            this.imgAroma.TabStop = false;
            // 
            // imgBrain
            // 
            this.imgBrain.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgBrain.Image = global::NipponAdvisor.GameIcons.Brain_24x;
            this.imgBrain.Location = new System.Drawing.Point(3, 34);
            this.imgBrain.Name = "imgBrain";
            this.imgBrain.Size = new System.Drawing.Size(24, 25);
            this.imgBrain.TabIndex = 5;
            this.imgBrain.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 330);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 53);
            this.panel1.TabIndex = 2;
            // 
            // DockDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.DefaultDockArea = DarkUI.Docking.DarkDockArea.Left;
            this.DockText = "Dish Info";
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = global::NipponAdvisor.GameIcons.Food_32x24;
            this.Name = "DockDish";
            this.Size = new System.Drawing.Size(204, 383);
            this.Load += new System.EventHandler(this.DockDish_Load);
            this.panelTop.ResumeLayout(false);
            this.tblLayoutDishInfo.ResumeLayout(false);
            this.tblLayoutDishInfo.PerformLayout();
            this.tblLayoutRating.ResumeLayout(false);
            this.tblLayoutRating.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderRating)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.tblLayoutStats.ResumeLayout(false);
            this.tblLayoutStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAppearance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRarity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCharisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTexture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAroma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBrain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TableLayoutPanel tblLayoutStats;
        private System.Windows.Forms.PictureBox imgHealth;
        private DarkUI.Controls.DarkTextBox textCharisma;
        private DarkUI.Controls.DarkTextBox textAroma;
        private DarkUI.Controls.DarkTextBox textRarity;
        private DarkUI.Controls.DarkTextBox textTexture;
        private DarkUI.Controls.DarkTextBox textVolume;
        private DarkUI.Controls.DarkTextBox textBrain;
        private DarkUI.Controls.DarkTextBox textAppearance;
        private System.Windows.Forms.PictureBox imgAppearance;
        private DarkUI.Controls.DarkTextBox textHealth;
        private System.Windows.Forms.PictureBox imgRarity;
        private System.Windows.Forms.PictureBox imgVolume;
        private System.Windows.Forms.PictureBox imgBrain;
        private System.Windows.Forms.PictureBox imgCharisma;
        private System.Windows.Forms.PictureBox imgTexture;
        private System.Windows.Forms.PictureBox imgAroma;
        private System.Windows.Forms.TableLayoutPanel tblLayoutDishInfo;
        private System.Windows.Forms.ComboBox ComboBaseDish;
        private DarkUI.Controls.DarkTitle titleRating;
        private System.Windows.Forms.TableLayoutPanel tblLayoutRating;
        private DarkUI.Controls.DarkLabel labelRating;
        private System.Windows.Forms.PictureBox imgRating;
        private System.Windows.Forms.TrackBar sliderRating;
        private DarkUI.Controls.DarkTitle titleDishName;
        private DarkUI.Controls.DarkTextBox textDishName;
        private System.Windows.Forms.Panel panel1;
    }
}
