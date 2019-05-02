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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblLayoutStats = new System.Windows.Forms.TableLayoutPanel();
            this.TextBoxCharisma = new DarkUI.Controls.DarkTextBox();
            this.TextBoxAroma = new DarkUI.Controls.DarkTextBox();
            this.TextBoxRarity = new DarkUI.Controls.DarkTextBox();
            this.TextBoxTexture = new DarkUI.Controls.DarkTextBox();
            this.TextBoxVolume = new DarkUI.Controls.DarkTextBox();
            this.TextBoxBrain = new DarkUI.Controls.DarkTextBox();
            this.TextBoxAppearance = new DarkUI.Controls.DarkTextBox();
            this.imgAppearance = new System.Windows.Forms.PictureBox();
            this.imgHealth = new System.Windows.Forms.PictureBox();
            this.TextBoxHealth = new DarkUI.Controls.DarkTextBox();
            this.imgRarity = new System.Windows.Forms.PictureBox();
            this.imgVolume = new System.Windows.Forms.PictureBox();
            this.imgCharisma = new System.Windows.Forms.PictureBox();
            this.imgTexture = new System.Windows.Forms.PictureBox();
            this.imgAroma = new System.Windows.Forms.PictureBox();
            this.imgBrain = new System.Windows.Forms.PictureBox();
            this.darkTitle4 = new DarkUI.Controls.DarkTitle();
            this.panelRating = new System.Windows.Forms.Panel();
            this.labelRating = new DarkUI.Controls.DarkLabel();
            this.imgRating = new System.Windows.Forms.PictureBox();
            this.SliderRating = new System.Windows.Forms.TrackBar();
            this.darkTitle3 = new DarkUI.Controls.DarkTitle();
            this.panelNickName = new System.Windows.Forms.Panel();
            this.TextBoxBaseDish = new DarkUI.Controls.DarkTextBox();
            this.darkTitle2 = new DarkUI.Controls.DarkTitle();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.ButtonNewDish = new DarkUI.Controls.DarkButton();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tblLayoutStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAppearance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRarity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCharisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTexture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAroma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBrain)).BeginInit();
            this.panelRating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderRating)).BeginInit();
            this.panelNickName.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.panelRating);
            this.panelMain.Controls.Add(this.panelNickName);
            this.panelMain.Controls.Add(this.panelButtons);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 25);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(10);
            this.panelMain.Size = new System.Drawing.Size(215, 323);
            this.panelMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tblLayoutStats);
            this.panel1.Controls.Add(this.darkTitle4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 162);
            this.panel1.TabIndex = 6;
            // 
            // tblLayoutStats
            // 
            this.tblLayoutStats.ColumnCount = 4;
            this.tblLayoutStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblLayoutStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblLayoutStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutStats.Controls.Add(this.TextBoxCharisma, 3, 3);
            this.tblLayoutStats.Controls.Add(this.TextBoxAroma, 1, 3);
            this.tblLayoutStats.Controls.Add(this.TextBoxRarity, 3, 2);
            this.tblLayoutStats.Controls.Add(this.TextBoxTexture, 1, 2);
            this.tblLayoutStats.Controls.Add(this.TextBoxVolume, 3, 1);
            this.tblLayoutStats.Controls.Add(this.TextBoxBrain, 1, 1);
            this.tblLayoutStats.Controls.Add(this.TextBoxAppearance, 3, 0);
            this.tblLayoutStats.Controls.Add(this.imgAppearance, 2, 0);
            this.tblLayoutStats.Controls.Add(this.imgHealth, 0, 0);
            this.tblLayoutStats.Controls.Add(this.TextBoxHealth, 1, 0);
            this.tblLayoutStats.Controls.Add(this.imgRarity, 2, 2);
            this.tblLayoutStats.Controls.Add(this.imgVolume, 2, 1);
            this.tblLayoutStats.Controls.Add(this.imgCharisma, 2, 3);
            this.tblLayoutStats.Controls.Add(this.imgTexture, 0, 2);
            this.tblLayoutStats.Controls.Add(this.imgAroma, 0, 3);
            this.tblLayoutStats.Controls.Add(this.imgBrain, 0, 1);
            this.tblLayoutStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblLayoutStats.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tblLayoutStats.Location = new System.Drawing.Point(0, 13);
            this.tblLayoutStats.Name = "tblLayoutStats";
            this.tblLayoutStats.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tblLayoutStats.RowCount = 4;
            this.tblLayoutStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutStats.Size = new System.Drawing.Size(195, 124);
            this.tblLayoutStats.TabIndex = 1;
            // 
            // TextBoxCharisma
            // 
            this.TextBoxCharisma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxCharisma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.TextBoxCharisma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxCharisma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBoxCharisma.Location = new System.Drawing.Point(130, 95);
            this.TextBoxCharisma.Name = "TextBoxCharisma";
            this.TextBoxCharisma.Size = new System.Drawing.Size(62, 22);
            this.TextBoxCharisma.TabIndex = 11;
            this.TextBoxCharisma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxAroma
            // 
            this.TextBoxAroma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxAroma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.TextBoxAroma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxAroma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBoxAroma.Location = new System.Drawing.Point(33, 95);
            this.TextBoxAroma.Name = "TextBoxAroma";
            this.TextBoxAroma.Size = new System.Drawing.Size(61, 22);
            this.TextBoxAroma.TabIndex = 7;
            this.TextBoxAroma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxRarity
            // 
            this.TextBoxRarity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxRarity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.TextBoxRarity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxRarity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBoxRarity.Location = new System.Drawing.Point(130, 66);
            this.TextBoxRarity.Name = "TextBoxRarity";
            this.TextBoxRarity.Size = new System.Drawing.Size(62, 22);
            this.TextBoxRarity.TabIndex = 10;
            this.TextBoxRarity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxTexture
            // 
            this.TextBoxTexture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxTexture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.TextBoxTexture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxTexture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBoxTexture.Location = new System.Drawing.Point(33, 66);
            this.TextBoxTexture.Name = "TextBoxTexture";
            this.TextBoxTexture.Size = new System.Drawing.Size(61, 22);
            this.TextBoxTexture.TabIndex = 6;
            this.TextBoxTexture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxVolume
            // 
            this.TextBoxVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.TextBoxVolume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBoxVolume.Location = new System.Drawing.Point(130, 37);
            this.TextBoxVolume.Name = "TextBoxVolume";
            this.TextBoxVolume.Size = new System.Drawing.Size(62, 22);
            this.TextBoxVolume.TabIndex = 9;
            this.TextBoxVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxBrain
            // 
            this.TextBoxBrain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxBrain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.TextBoxBrain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxBrain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBoxBrain.Location = new System.Drawing.Point(33, 37);
            this.TextBoxBrain.Name = "TextBoxBrain";
            this.TextBoxBrain.Size = new System.Drawing.Size(61, 22);
            this.TextBoxBrain.TabIndex = 5;
            this.TextBoxBrain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxAppearance
            // 
            this.TextBoxAppearance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.TextBoxAppearance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBoxAppearance.Location = new System.Drawing.Point(130, 8);
            this.TextBoxAppearance.Name = "TextBoxAppearance";
            this.TextBoxAppearance.Size = new System.Drawing.Size(62, 22);
            this.TextBoxAppearance.TabIndex = 8;
            this.TextBoxAppearance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imgAppearance
            // 
            this.imgAppearance.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgAppearance.Image = global::NipponAdvisor.GameIcons.Appearance_24x;
            this.imgAppearance.Location = new System.Drawing.Point(100, 8);
            this.imgAppearance.Name = "imgAppearance";
            this.imgAppearance.Size = new System.Drawing.Size(24, 23);
            this.imgAppearance.TabIndex = 4;
            this.imgAppearance.TabStop = false;
            // 
            // imgHealth
            // 
            this.imgHealth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgHealth.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgHealth.Image = global::NipponAdvisor.GameIcons.Health_24x;
            this.imgHealth.Location = new System.Drawing.Point(3, 8);
            this.imgHealth.Name = "imgHealth";
            this.imgHealth.Size = new System.Drawing.Size(24, 23);
            this.imgHealth.TabIndex = 0;
            this.imgHealth.TabStop = false;
            // 
            // TextBoxHealth
            // 
            this.TextBoxHealth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxHealth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.TextBoxHealth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBoxHealth.Location = new System.Drawing.Point(33, 8);
            this.TextBoxHealth.Name = "TextBoxHealth";
            this.TextBoxHealth.Size = new System.Drawing.Size(61, 22);
            this.TextBoxHealth.TabIndex = 4;
            this.TextBoxHealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imgRarity
            // 
            this.imgRarity.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgRarity.Image = global::NipponAdvisor.GameIcons.Rarity_24x;
            this.imgRarity.Location = new System.Drawing.Point(100, 66);
            this.imgRarity.Name = "imgRarity";
            this.imgRarity.Size = new System.Drawing.Size(24, 23);
            this.imgRarity.TabIndex = 3;
            this.imgRarity.TabStop = false;
            // 
            // imgVolume
            // 
            this.imgVolume.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgVolume.Image = global::NipponAdvisor.GameIcons.Volume_24x;
            this.imgVolume.Location = new System.Drawing.Point(100, 37);
            this.imgVolume.Name = "imgVolume";
            this.imgVolume.Size = new System.Drawing.Size(24, 23);
            this.imgVolume.TabIndex = 2;
            this.imgVolume.TabStop = false;
            // 
            // imgCharisma
            // 
            this.imgCharisma.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgCharisma.Image = global::NipponAdvisor.GameIcons.Charisma_24x;
            this.imgCharisma.Location = new System.Drawing.Point(100, 95);
            this.imgCharisma.Name = "imgCharisma";
            this.imgCharisma.Size = new System.Drawing.Size(24, 26);
            this.imgCharisma.TabIndex = 6;
            this.imgCharisma.TabStop = false;
            // 
            // imgTexture
            // 
            this.imgTexture.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgTexture.Image = global::NipponAdvisor.GameIcons.Texture_24x;
            this.imgTexture.Location = new System.Drawing.Point(3, 66);
            this.imgTexture.Name = "imgTexture";
            this.imgTexture.Size = new System.Drawing.Size(24, 23);
            this.imgTexture.TabIndex = 7;
            this.imgTexture.TabStop = false;
            // 
            // imgAroma
            // 
            this.imgAroma.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgAroma.Image = global::NipponAdvisor.GameIcons.Aroma_24x;
            this.imgAroma.Location = new System.Drawing.Point(3, 95);
            this.imgAroma.Name = "imgAroma";
            this.imgAroma.Size = new System.Drawing.Size(24, 26);
            this.imgAroma.TabIndex = 8;
            this.imgAroma.TabStop = false;
            // 
            // imgBrain
            // 
            this.imgBrain.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgBrain.Image = global::NipponAdvisor.GameIcons.Brain_24x;
            this.imgBrain.Location = new System.Drawing.Point(3, 37);
            this.imgBrain.Name = "imgBrain";
            this.imgBrain.Size = new System.Drawing.Size(24, 23);
            this.imgBrain.TabIndex = 5;
            this.imgBrain.TabStop = false;
            // 
            // darkTitle4
            // 
            this.darkTitle4.Dock = System.Windows.Forms.DockStyle.Top;
            this.darkTitle4.Location = new System.Drawing.Point(0, 0);
            this.darkTitle4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.darkTitle4.Name = "darkTitle4";
            this.darkTitle4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.darkTitle4.Size = new System.Drawing.Size(195, 13);
            this.darkTitle4.TabIndex = 0;
            this.darkTitle4.Text = "Dish Stats";
            // 
            // panelRating
            // 
            this.panelRating.Controls.Add(this.labelRating);
            this.panelRating.Controls.Add(this.imgRating);
            this.panelRating.Controls.Add(this.SliderRating);
            this.panelRating.Controls.Add(this.darkTitle3);
            this.panelRating.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRating.Location = new System.Drawing.Point(10, 84);
            this.panelRating.Name = "panelRating";
            this.panelRating.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelRating.Size = new System.Drawing.Size(195, 67);
            this.panelRating.TabIndex = 5;
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelRating.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelRating.Location = new System.Drawing.Point(180, 23);
            this.labelRating.Margin = new System.Windows.Forms.Padding(0);
            this.labelRating.Name = "labelRating";
            this.labelRating.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.labelRating.Size = new System.Drawing.Size(15, 23);
            this.labelRating.TabIndex = 20;
            this.labelRating.Text = "1";
            // 
            // imgRating
            // 
            this.imgRating.Dock = System.Windows.Forms.DockStyle.Left;
            this.imgRating.Image = global::NipponAdvisor.GameIcons.Star_24x;
            this.imgRating.Location = new System.Drawing.Point(156, 23);
            this.imgRating.Margin = new System.Windows.Forms.Padding(0);
            this.imgRating.Name = "imgRating";
            this.imgRating.Size = new System.Drawing.Size(24, 44);
            this.imgRating.TabIndex = 19;
            this.imgRating.TabStop = false;
            // 
            // SliderRating
            // 
            this.SliderRating.Dock = System.Windows.Forms.DockStyle.Left;
            this.SliderRating.LargeChange = 3;
            this.SliderRating.Location = new System.Drawing.Point(0, 23);
            this.SliderRating.Margin = new System.Windows.Forms.Padding(0);
            this.SliderRating.Maximum = 9;
            this.SliderRating.Minimum = 1;
            this.SliderRating.Name = "SliderRating";
            this.SliderRating.Size = new System.Drawing.Size(156, 44);
            this.SliderRating.TabIndex = 18;
            this.SliderRating.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.SliderRating.Value = 1;
            this.SliderRating.ValueChanged += new System.EventHandler(this.Rating_Changed);
            // 
            // darkTitle3
            // 
            this.darkTitle3.Dock = System.Windows.Forms.DockStyle.Top;
            this.darkTitle3.Location = new System.Drawing.Point(0, 10);
            this.darkTitle3.Margin = new System.Windows.Forms.Padding(3, 12, 3, 10);
            this.darkTitle3.Name = "darkTitle3";
            this.darkTitle3.Padding = new System.Windows.Forms.Padding(0, 12, 0, 10);
            this.darkTitle3.Size = new System.Drawing.Size(195, 13);
            this.darkTitle3.TabIndex = 4;
            this.darkTitle3.Text = "Rating";
            // 
            // panelNickName
            // 
            this.panelNickName.Controls.Add(this.TextBoxBaseDish);
            this.panelNickName.Controls.Add(this.darkTitle2);
            this.panelNickName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNickName.Location = new System.Drawing.Point(10, 40);
            this.panelNickName.Margin = new System.Windows.Forms.Padding(5);
            this.panelNickName.Name = "panelNickName";
            this.panelNickName.Size = new System.Drawing.Size(195, 44);
            this.panelNickName.TabIndex = 4;
            // 
            // TextBoxBaseDish
            // 
            this.TextBoxBaseDish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.TextBoxBaseDish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxBaseDish.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextBoxBaseDish.Enabled = false;
            this.TextBoxBaseDish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBoxBaseDish.Location = new System.Drawing.Point(0, 22);
            this.TextBoxBaseDish.Margin = new System.Windows.Forms.Padding(3, 12, 3, 10);
            this.TextBoxBaseDish.Name = "TextBoxBaseDish";
            this.TextBoxBaseDish.Size = new System.Drawing.Size(195, 22);
            this.TextBoxBaseDish.TabIndex = 5;
            // 
            // darkTitle2
            // 
            this.darkTitle2.Dock = System.Windows.Forms.DockStyle.Top;
            this.darkTitle2.Location = new System.Drawing.Point(0, 0);
            this.darkTitle2.Margin = new System.Windows.Forms.Padding(3, 12, 3, 10);
            this.darkTitle2.Name = "darkTitle2";
            this.darkTitle2.Padding = new System.Windows.Forms.Padding(0, 12, 0, 10);
            this.darkTitle2.Size = new System.Drawing.Size(195, 13);
            this.darkTitle2.TabIndex = 3;
            this.darkTitle2.Text = "Base Dish";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.ButtonNewDish);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(10, 10);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(195, 30);
            this.panelButtons.TabIndex = 1;
            // 
            // ButtonNewDish
            // 
            this.ButtonNewDish.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonNewDish.Location = new System.Drawing.Point(0, 0);
            this.ButtonNewDish.Name = "ButtonNewDish";
            this.ButtonNewDish.Padding = new System.Windows.Forms.Padding(5);
            this.ButtonNewDish.Size = new System.Drawing.Size(195, 23);
            this.ButtonNewDish.TabIndex = 1;
            this.ButtonNewDish.Text = "New";
            this.ButtonNewDish.Click += new System.EventHandler(this.BtnNewDish_Click);
            // 
            // DockCafeDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.panelMain);
            this.DockText = "Custom Dish";
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Icon = global::NipponAdvisor.GameIcons.Food_16x11;
            this.Name = "DockCafeDish";
            this.Size = new System.Drawing.Size(215, 348);
            this.panelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
            this.panelRating.ResumeLayout(false);
            this.panelRating.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderRating)).EndInit();
            this.panelNickName.ResumeLayout(false);
            this.panelNickName.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelRating;
        private DarkUI.Controls.DarkLabel labelRating;
        private System.Windows.Forms.PictureBox imgRating;
        private System.Windows.Forms.TrackBar SliderRating;
        private DarkUI.Controls.DarkTitle darkTitle3;
        private System.Windows.Forms.Panel panel1;
        private DarkUI.Controls.DarkTitle darkTitle4;
        private System.Windows.Forms.TableLayoutPanel tblLayoutStats;
        private DarkUI.Controls.DarkTextBox TextBoxCharisma;
        private DarkUI.Controls.DarkTextBox TextBoxAroma;
        private DarkUI.Controls.DarkTextBox TextBoxRarity;
        private DarkUI.Controls.DarkTextBox TextBoxTexture;
        private DarkUI.Controls.DarkTextBox TextBoxVolume;
        private DarkUI.Controls.DarkTextBox TextBoxBrain;
        private DarkUI.Controls.DarkTextBox TextBoxAppearance;
        private System.Windows.Forms.PictureBox imgAppearance;
        private System.Windows.Forms.PictureBox imgHealth;
        private DarkUI.Controls.DarkTextBox TextBoxHealth;
        private System.Windows.Forms.PictureBox imgRarity;
        private System.Windows.Forms.PictureBox imgVolume;
        private System.Windows.Forms.PictureBox imgCharisma;
        private System.Windows.Forms.PictureBox imgTexture;
        private System.Windows.Forms.PictureBox imgAroma;
        private System.Windows.Forms.PictureBox imgBrain;
        private System.Windows.Forms.Panel panelNickName;
        private DarkUI.Controls.DarkTextBox TextBoxBaseDish;
        private DarkUI.Controls.DarkTitle darkTitle2;
        private DarkUI.Controls.DarkButton ButtonNewDish;
    }
}
