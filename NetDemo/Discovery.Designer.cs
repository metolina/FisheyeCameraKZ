namespace NetDemo
{
    partial class Discovery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Discovery));
            this.segmentSearchBtn = new System.Windows.Forms.Button();
            this.DeviceInfoListView = new System.Windows.Forms.ListView();
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MAC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SerialNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Manufacturer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Device_Number = new System.Windows.Forms.Label();
            this.deviceNumberLabel = new System.Windows.Forms.Label();
            this.Auto_Search = new System.Windows.Forms.Label();
            this.AutoSearchBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.endIPText = new System.Windows.Forms.TextBox();
            this.startIPext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addDeviceBtn = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // segmentSearchBtn
            // 
            this.segmentSearchBtn.Location = new System.Drawing.Point(200, 117);
            this.segmentSearchBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.segmentSearchBtn.Name = "segmentSearchBtn";
            this.segmentSearchBtn.Size = new System.Drawing.Size(80, 30);
            this.segmentSearchBtn.TabIndex = 0;
            this.segmentSearchBtn.Text = "Gelişmiş Ara";
            this.segmentSearchBtn.UseVisualStyleBackColor = true;
            this.segmentSearchBtn.Click += new System.EventHandler(this.segmentSearchBtn_Click);
            // 
            // DeviceInfoListView
            // 
            this.DeviceInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type,
            this.IP,
            this.Port,
            this.MAC,
            this.SerialNum,
            this.Manufacturer});
            this.DeviceInfoListView.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeviceInfoListView.FullRowSelect = true;
            this.DeviceInfoListView.GridLines = true;
            this.DeviceInfoListView.HideSelection = false;
            this.DeviceInfoListView.Location = new System.Drawing.Point(34, 43);
            this.DeviceInfoListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeviceInfoListView.Name = "DeviceInfoListView";
            this.DeviceInfoListView.Size = new System.Drawing.Size(937, 231);
            this.DeviceInfoListView.TabIndex = 2;
            this.DeviceInfoListView.UseCompatibleStateImageBehavior = false;
            this.DeviceInfoListView.View = System.Windows.Forms.View.Details;
            this.DeviceInfoListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.DeviceInfoListView_ItemSelectionChanged);
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 120;
            // 
            // IP
            // 
            this.IP.Text = "IP";
            this.IP.Width = 165;
            // 
            // Port
            // 
            this.Port.Text = "Port";
            this.Port.Width = 80;
            // 
            // MAC
            // 
            this.MAC.Text = "MAC";
            this.MAC.Width = 185;
            // 
            // SerialNum
            // 
            this.SerialNum.Text = "SerialNum";
            this.SerialNum.Width = 185;
            // 
            // Manufacturer
            // 
            this.Manufacturer.Text = "Manufacturer";
            this.Manufacturer.Width = 180;
            // 
            // Device_Number
            // 
            this.Device_Number.AutoSize = true;
            this.Device_Number.Location = new System.Drawing.Point(680, 444);
            this.Device_Number.Name = "Device_Number";
            this.Device_Number.Size = new System.Drawing.Size(95, 16);
            this.Device_Number.TabIndex = 3;
            this.Device_Number.Text = "Bulunan Cihazlar";
            this.Device_Number.Visible = false;
            // 
            // deviceNumberLabel
            // 
            this.deviceNumberLabel.AutoSize = true;
            this.deviceNumberLabel.Location = new System.Drawing.Point(944, 480);
            this.deviceNumberLabel.Name = "deviceNumberLabel";
            this.deviceNumberLabel.Size = new System.Drawing.Size(13, 16);
            this.deviceNumberLabel.TabIndex = 4;
            this.deviceNumberLabel.Text = "0";
            this.deviceNumberLabel.Visible = false;
            // 
            // Auto_Search
            // 
            this.Auto_Search.AutoSize = true;
            this.Auto_Search.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Auto_Search.Location = new System.Drawing.Point(32, 297);
            this.Auto_Search.Name = "Auto_Search";
            this.Auto_Search.Size = new System.Drawing.Size(187, 22);
            this.Auto_Search.TabIndex = 5;
            this.Auto_Search.Text = "Otomatik Kamera Ara";
            // 
            // AutoSearchBtn
            // 
            this.AutoSearchBtn.Location = new System.Drawing.Point(590, 462);
            this.AutoSearchBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AutoSearchBtn.Name = "AutoSearchBtn";
            this.AutoSearchBtn.Size = new System.Drawing.Size(80, 30);
            this.AutoSearchBtn.TabIndex = 6;
            this.AutoSearchBtn.Text = "Ara";
            this.AutoSearchBtn.UseVisualStyleBackColor = true;
            this.AutoSearchBtn.Visible = false;
            this.AutoSearchBtn.Click += new System.EventHandler(this.AutoSearchBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.endIPText);
            this.groupBox1.Controls.Add(this.startIPext);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.segmentSearchBtn);
            this.groupBox1.Location = new System.Drawing.Point(918, 116);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(31, 14);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama Ayarları";
            this.groupBox1.Visible = false;
            // 
            // endIPText
            // 
            this.endIPText.Location = new System.Drawing.Point(92, 81);
            this.endIPText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.endIPText.Name = "endIPText";
            this.endIPText.Size = new System.Drawing.Size(188, 22);
            this.endIPText.TabIndex = 3;
            // 
            // startIPext
            // 
            this.startIPext.Location = new System.Drawing.Point(92, 37);
            this.startIPext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startIPext.Name = "startIPext";
            this.startIPext.Size = new System.Drawing.Size(188, 22);
            this.startIPext.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bitiş  IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Başlangıç IP";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(845, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Not : Eklenecek cihazı listeden seçerek ekleyin.";
            this.label3.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.passwordText);
            this.groupBox2.Controls.Add(this.userNameText);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.addDeviceBtn);
            this.groupBox2.Location = new System.Drawing.Point(803, 441);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(96, 51);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cihaz Kullanıcı ";
            this.groupBox2.Visible = false;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(90, 73);
            this.passwordText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordText.MaxLength = 64;
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(191, 22);
            this.passwordText.TabIndex = 2;
            this.passwordText.Text = "kz-102030";
            // 
            // userNameText
            // 
            this.userNameText.Location = new System.Drawing.Point(90, 37);
            this.userNameText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(191, 22);
            this.userNameText.TabIndex = 2;
            this.userNameText.Text = "admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kullanıcı Adı";
            // 
            // addDeviceBtn
            // 
            this.addDeviceBtn.Location = new System.Drawing.Point(200, 128);
            this.addDeviceBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addDeviceBtn.Name = "addDeviceBtn";
            this.addDeviceBtn.Size = new System.Drawing.Size(80, 30);
            this.addDeviceBtn.TabIndex = 0;
            this.addDeviceBtn.Text = "Ekle";
            this.addDeviceBtn.UseVisualStyleBackColor = true;
            this.addDeviceBtn.Click += new System.EventHandler(this.addDeviceBtn_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Transparent;
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button13.FlatAppearance.BorderSize = 3;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.Black;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(34, 322);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(185, 58);
            this.button13.TabIndex = 859;
            this.button13.Text = "      ARA";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(780, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 58);
            this.button1.TabIndex = 860;
            this.button1.Text = "      KAPAT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel8.Location = new System.Drawing.Point(-27, 423);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1225, 6);
            this.panel8.TabIndex = 862;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(-131, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 6);
            this.panel1.TabIndex = 863;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(1007, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(6, 500);
            this.panel2.TabIndex = 864;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(6, 500);
            this.panel3.TabIndex = 865;
            // 
            // Discovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1013, 429);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AutoSearchBtn);
            this.Controls.Add(this.Auto_Search);
            this.Controls.Add(this.deviceNumberLabel);
            this.Controls.Add(this.Device_Number);
            this.Controls.Add(this.DeviceInfoListView);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Discovery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KZ Kamera Bul";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Discovery_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button segmentSearchBtn;
        private System.Windows.Forms.ListView DeviceInfoListView;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader IP;
        private System.Windows.Forms.ColumnHeader Port;
        private System.Windows.Forms.ColumnHeader MAC;
        private System.Windows.Forms.ColumnHeader SerialNum;
        private System.Windows.Forms.ColumnHeader Manufacturer;
        private System.Windows.Forms.Label Device_Number;
        private System.Windows.Forms.Label deviceNumberLabel;
        private System.Windows.Forms.Label Auto_Search;
        private System.Windows.Forms.Button AutoSearchBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox endIPText;
        private System.Windows.Forms.TextBox startIPext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addDeviceBtn;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}