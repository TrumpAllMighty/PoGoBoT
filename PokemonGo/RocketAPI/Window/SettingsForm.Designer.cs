﻿namespace PokemonGo.RocketAPI.Window
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.authTypeLabel = new System.Windows.Forms.Label();
            this.authTypeCb = new System.Windows.Forms.ComboBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.latLabel = new System.Windows.Forms.Label();
            this.longiLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UserLoginBox = new System.Windows.Forms.TextBox();
            this.UserPasswordBox = new System.Windows.Forms.TextBox();
            this.latitudeText = new System.Windows.Forms.TextBox();
            this.longitudeText = new System.Windows.Forms.TextBox();
            this.razzmodeCb = new System.Windows.Forms.ComboBox();
            this.razzSettingText = new System.Windows.Forms.TextBox();
            this.transferTypeCb = new System.Windows.Forms.ComboBox();
            this.transferCpThresText = new System.Windows.Forms.TextBox();
            this.evolveAllChk = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FindAdressButton = new System.Windows.Forms.Button();
            this.AdressBox = new System.Windows.Forms.TextBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TravelSpeedBox = new System.Windows.Forms.TextBox();
            this.CatchPokemonBox = new System.Windows.Forms.CheckBox();
            this.CatchPokemonText = new System.Windows.Forms.Label();
            this.transferIVThresText = new System.Windows.Forms.TextBox();
            this.TravelSpeedText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboLocations = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // authTypeLabel
            // 
            this.authTypeLabel.AutoSize = true;
            this.authTypeLabel.Location = new System.Drawing.Point(3, 8);
            this.authTypeLabel.Name = "authTypeLabel";
            this.authTypeLabel.Size = new System.Drawing.Size(63, 13);
            this.authTypeLabel.TabIndex = 0;
            this.authTypeLabel.Text = "Login Type:";
            this.authTypeLabel.Click += new System.EventHandler(this.authTypeLabel_Click);
            // 
            // authTypeCb
            // 
            this.authTypeCb.FormattingEnabled = true;
            this.authTypeCb.Items.AddRange(new object[] {
            "google",
            "Ptc"});
            this.authTypeCb.Location = new System.Drawing.Point(82, 4);
            this.authTypeCb.Name = "authTypeCb";
            this.authTypeCb.Size = new System.Drawing.Size(136, 21);
            this.authTypeCb.TabIndex = 1;
            this.authTypeCb.SelectedIndexChanged += new System.EventHandler(this.authTypeCb_SelectedIndexChanged);
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(3, 36);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(58, 13);
            this.UserLabel.TabIndex = 2;
            this.UserLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(3, 62);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password:";
            // 
            // latLabel
            // 
            this.latLabel.AutoSize = true;
            this.latLabel.Location = new System.Drawing.Point(3, 88);
            this.latLabel.Name = "latLabel";
            this.latLabel.Size = new System.Drawing.Size(48, 13);
            this.latLabel.TabIndex = 4;
            this.latLabel.Text = "Latitude:";
            // 
            // longiLabel
            // 
            this.longiLabel.AutoSize = true;
            this.longiLabel.Location = new System.Drawing.Point(3, 114);
            this.longiLabel.Name = "longiLabel";
            this.longiLabel.Size = new System.Drawing.Size(57, 13);
            this.longiLabel.TabIndex = 5;
            this.longiLabel.Text = "Longitude:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Razzberry Mode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Transfer Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Evolve Pokemon:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "CP Threshold:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Razzberry Setting:";
            // 
            // UserLoginBox
            // 
            this.UserLoginBox.Location = new System.Drawing.Point(82, 34);
            this.UserLoginBox.Name = "UserLoginBox";
            this.UserLoginBox.Size = new System.Drawing.Size(136, 20);
            this.UserLoginBox.TabIndex = 11;
            // 
            // UserPasswordBox
            // 
            this.UserPasswordBox.Location = new System.Drawing.Point(82, 62);
            this.UserPasswordBox.Name = "UserPasswordBox";
            this.UserPasswordBox.PasswordChar = '•';
            this.UserPasswordBox.Size = new System.Drawing.Size(136, 20);
            this.UserPasswordBox.TabIndex = 12;
            // 
            // latitudeText
            // 
            this.latitudeText.Location = new System.Drawing.Point(118, 86);
            this.latitudeText.Name = "latitudeText";
            this.latitudeText.Size = new System.Drawing.Size(100, 20);
            this.latitudeText.TabIndex = 13;
            // 
            // longitudeText
            // 
            this.longitudeText.Location = new System.Drawing.Point(118, 112);
            this.longitudeText.Name = "longitudeText";
            this.longitudeText.Size = new System.Drawing.Size(100, 20);
            this.longitudeText.TabIndex = 14;
            // 
            // razzmodeCb
            // 
            this.razzmodeCb.FormattingEnabled = true;
            this.razzmodeCb.Items.AddRange(new object[] {
            "probability",
            "cp"});
            this.razzmodeCb.Location = new System.Drawing.Point(118, 138);
            this.razzmodeCb.Name = "razzmodeCb";
            this.razzmodeCb.Size = new System.Drawing.Size(100, 21);
            this.razzmodeCb.TabIndex = 15;
            // 
            // razzSettingText
            // 
            this.razzSettingText.Location = new System.Drawing.Point(118, 165);
            this.razzSettingText.Name = "razzSettingText";
            this.razzSettingText.Size = new System.Drawing.Size(100, 20);
            this.razzSettingText.TabIndex = 16;
            // 
            // transferTypeCb
            // 
            this.transferTypeCb.FormattingEnabled = true;
            this.transferTypeCb.Items.AddRange(new object[] {
            "None",
            "CP",
            "IV",
            "Leave Strongest",
            "Duplicate",
            "IV Duplicate",
            "All"});
            this.transferTypeCb.Location = new System.Drawing.Point(118, 191);
            this.transferTypeCb.Name = "transferTypeCb";
            this.transferTypeCb.Size = new System.Drawing.Size(100, 21);
            this.transferTypeCb.TabIndex = 17;
            this.transferTypeCb.SelectedIndexChanged += new System.EventHandler(this.transferTypeCb_SelectedIndexChanged);
            // 
            // transferCpThresText
            // 
            this.transferCpThresText.Location = new System.Drawing.Point(118, 219);
            this.transferCpThresText.Name = "transferCpThresText";
            this.transferCpThresText.Size = new System.Drawing.Size(100, 20);
            this.transferCpThresText.TabIndex = 18;
            this.transferCpThresText.TextChanged += new System.EventHandler(this.transferCpThresText_TextChanged);
            // 
            // evolveAllChk
            // 
            this.evolveAllChk.AutoSize = true;
            this.evolveAllChk.Location = new System.Drawing.Point(118, 321);
            this.evolveAllChk.Name = "evolveAllChk";
            this.evolveAllChk.Size = new System.Drawing.Size(15, 14);
            this.evolveAllChk.TabIndex = 19;
            this.evolveAllChk.UseVisualStyleBackColor = true;
            this.evolveAllChk.CheckedChanged += new System.EventHandler(this.evolveAllChk_CheckedChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Location = new System.Drawing.Point(3, 341);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(218, 95);
            this.saveBtn.TabIndex = 20;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // gMapControl1
            // 
            this.gMapControl1.BackColor = System.Drawing.SystemColors.Info;
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(6, 45);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(468, 359);
            this.gMapControl1.TabIndex = 22;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            this.gMapControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboLocations);
            this.groupBox1.Controls.Add(this.FindAdressButton);
            this.groupBox1.Controls.Add(this.AdressBox);
            this.groupBox1.Controls.Add(this.trackBar);
            this.groupBox1.Controls.Add(this.gMapControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(233, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 441);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location";
            // 
            // FindAdressButton
            // 
            this.FindAdressButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindAdressButton.Location = new System.Drawing.Point(352, 19);
            this.FindAdressButton.Name = "FindAdressButton";
            this.FindAdressButton.Size = new System.Drawing.Size(119, 20);
            this.FindAdressButton.TabIndex = 25;
            this.FindAdressButton.Text = "Find Location";
            this.FindAdressButton.UseVisualStyleBackColor = true;
            this.FindAdressButton.Click += new System.EventHandler(this.FindAdressButton_Click_1);
            // 
            // AdressBox
            // 
            this.AdressBox.Location = new System.Drawing.Point(15, 19);
            this.AdressBox.Name = "AdressBox";
            this.AdressBox.Size = new System.Drawing.Size(331, 20);
            this.AdressBox.TabIndex = 25;
            // 
            // trackBar
            // 
            this.trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar.BackColor = System.Drawing.SystemColors.Info;
            this.trackBar.Location = new System.Drawing.Point(429, 45);
            this.trackBar.Name = "trackBar";
            this.trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar.Size = new System.Drawing.Size(45, 104);
            this.trackBar.TabIndex = 25;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TravelSpeedBox);
            this.panel1.Controls.Add(this.CatchPokemonBox);
            this.panel1.Controls.Add(this.CatchPokemonText);
            this.panel1.Controls.Add(this.transferIVThresText);
            this.panel1.Controls.Add(this.TravelSpeedText);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.authTypeLabel);
            this.panel1.Controls.Add(this.authTypeCb);
            this.panel1.Controls.Add(this.UserLabel);
            this.panel1.Controls.Add(this.PasswordLabel);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.latLabel);
            this.panel1.Controls.Add(this.evolveAllChk);
            this.panel1.Controls.Add(this.longiLabel);
            this.panel1.Controls.Add(this.transferCpThresText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.transferTypeCb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.razzSettingText);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.razzmodeCb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.longitudeText);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.latitudeText);
            this.panel1.Controls.Add(this.UserLoginBox);
            this.panel1.Controls.Add(this.UserPasswordBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 441);
            this.panel1.TabIndex = 26;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TravelSpeedBox
            // 
            this.TravelSpeedBox.Location = new System.Drawing.Point(118, 272);
            this.TravelSpeedBox.Name = "TravelSpeedBox";
            this.TravelSpeedBox.Size = new System.Drawing.Size(100, 20);
            this.TravelSpeedBox.TabIndex = 22;
            this.TravelSpeedBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CatchPokemonBox
            // 
            this.CatchPokemonBox.AutoSize = true;
            this.CatchPokemonBox.Location = new System.Drawing.Point(118, 298);
            this.CatchPokemonBox.Name = "CatchPokemonBox";
            this.CatchPokemonBox.Size = new System.Drawing.Size(15, 14);
            this.CatchPokemonBox.TabIndex = 26;
            this.CatchPokemonBox.UseVisualStyleBackColor = true;
            this.CatchPokemonBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CatchPokemonText
            // 
            this.CatchPokemonText.AutoSize = true;
            this.CatchPokemonText.Location = new System.Drawing.Point(3, 298);
            this.CatchPokemonText.Name = "CatchPokemonText";
            this.CatchPokemonText.Size = new System.Drawing.Size(86, 13);
            this.CatchPokemonText.TabIndex = 25;
            this.CatchPokemonText.Text = "Catch Pokemon:";
            this.CatchPokemonText.Click += new System.EventHandler(this.label7_Click);
            // 
            // transferIVThresText
            // 
            this.transferIVThresText.Location = new System.Drawing.Point(118, 220);
            this.transferIVThresText.Name = "transferIVThresText";
            this.transferIVThresText.Size = new System.Drawing.Size(100, 20);
            this.transferIVThresText.TabIndex = 24;
            this.transferIVThresText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TravelSpeedText
            // 
            this.TravelSpeedText.AutoSize = true;
            this.TravelSpeedText.Location = new System.Drawing.Point(3, 275);
            this.TravelSpeedText.Name = "TravelSpeedText";
            this.TravelSpeedText.Size = new System.Drawing.Size(102, 13);
            this.TravelSpeedText.TabIndex = 23;
            this.TravelSpeedText.Text = "Travel Speed km/h:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "IV Threshold:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboLocations
            // 
            this.comboLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLocations.FormattingEnabled = true;
            this.comboLocations.Location = new System.Drawing.Point(6, 410);
            this.comboLocations.Name = "comboLocations";
            this.comboLocations.Size = new System.Drawing.Size(468, 21);
            this.comboLocations.TabIndex = 28;
            this.comboLocations.SelectedIndexChanged += new System.EventHandler(this.comboLocations_SelectedIndexChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 459);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(630, 359);
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label authTypeLabel;
        private System.Windows.Forms.ComboBox authTypeCb;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label latLabel;
        private System.Windows.Forms.Label longiLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UserLoginBox;
        private System.Windows.Forms.TextBox UserPasswordBox;
        private System.Windows.Forms.TextBox latitudeText;
        private System.Windows.Forms.TextBox longitudeText;
        private System.Windows.Forms.ComboBox razzmodeCb;
        private System.Windows.Forms.TextBox razzSettingText;
        private System.Windows.Forms.ComboBox transferTypeCb;
        private System.Windows.Forms.TextBox transferCpThresText;
        private System.Windows.Forms.CheckBox evolveAllChk;
        private System.Windows.Forms.Button saveBtn;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBar;
        private CueTextBox textBoxAddress;
        private System.Windows.Forms.TextBox TravelSpeedBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TravelSpeedText;
        private System.Windows.Forms.TextBox transferIVThresText;
        private System.Windows.Forms.TextBox AdressBox;
        private System.Windows.Forms.Button FindAdressButton;
        private System.Windows.Forms.CheckBox CatchPokemonBox;
        private System.Windows.Forms.Label CatchPokemonText;
        private System.Windows.Forms.ComboBox comboLocations;
    }
}
