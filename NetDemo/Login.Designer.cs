namespace NetDemo
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numeric_0 = new System.Windows.Forms.Button();
            this.numeric_2 = new System.Windows.Forms.Button();
            this.numeric_3 = new System.Windows.Forms.Button();
            this.numeric_4 = new System.Windows.Forms.Button();
            this.numeric_5 = new System.Windows.Forms.Button();
            this.numeric_6 = new System.Windows.Forms.Button();
            this.numeric_7 = new System.Windows.Forms.Button();
            this.numeric_8 = new System.Windows.Forms.Button();
            this.numeric_9 = new System.Windows.Forms.Button();
            this.numeric_1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.led = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button67 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(346, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.Location = new System.Drawing.Point(444, 207);
            this.txt_sifre.Multiline = true;
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(223, 55);
            this.txt_sifre.TabIndex = 2;
            this.txt_sifre.Click += new System.EventHandler(this.txt_sifre_Click);
            this.txt_sifre.TextChanged += new System.EventHandler(this.txt_sifre_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(352, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 65);
            this.button1.TabIndex = 3;
            this.button1.Text = "Giriş İçin Tıklayınız";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.numeric_0);
            this.groupBox1.Controls.Add(this.numeric_2);
            this.groupBox1.Controls.Add(this.numeric_3);
            this.groupBox1.Controls.Add(this.numeric_4);
            this.groupBox1.Controls.Add(this.numeric_5);
            this.groupBox1.Controls.Add(this.numeric_6);
            this.groupBox1.Controls.Add(this.numeric_7);
            this.groupBox1.Controls.Add(this.numeric_8);
            this.groupBox1.Controls.Add(this.numeric_9);
            this.groupBox1.Controls.Add(this.numeric_1);
            this.groupBox1.Location = new System.Drawing.Point(272, 383);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 205);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(29, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 70);
            this.button3.TabIndex = 11;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(373, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 70);
            this.button2.TabIndex = 10;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numeric_0
            // 
            this.numeric_0.BackColor = System.Drawing.Color.White;
            this.numeric_0.FlatAppearance.BorderSize = 2;
            this.numeric_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numeric_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numeric_0.Location = new System.Drawing.Point(152, 259);
            this.numeric_0.Name = "numeric_0";
            this.numeric_0.Size = new System.Drawing.Size(70, 70);
            this.numeric_0.TabIndex = 9;
            this.numeric_0.Text = "0";
            this.numeric_0.UseVisualStyleBackColor = false;
            this.numeric_0.Visible = false;
            this.numeric_0.Click += new System.EventHandler(this.numeric_0_Click);
            // 
            // numeric_2
            // 
            this.numeric_2.BackColor = System.Drawing.Color.White;
            this.numeric_2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.numeric_2.FlatAppearance.BorderSize = 3;
            this.numeric_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numeric_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numeric_2.Location = new System.Drawing.Point(105, 19);
            this.numeric_2.Name = "numeric_2";
            this.numeric_2.Size = new System.Drawing.Size(70, 70);
            this.numeric_2.TabIndex = 8;
            this.numeric_2.Text = "2";
            this.numeric_2.UseVisualStyleBackColor = false;
            this.numeric_2.Click += new System.EventHandler(this.numeric_2_Click);
            // 
            // numeric_3
            // 
            this.numeric_3.BackColor = System.Drawing.Color.White;
            this.numeric_3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.numeric_3.FlatAppearance.BorderSize = 3;
            this.numeric_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numeric_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numeric_3.Location = new System.Drawing.Point(192, 19);
            this.numeric_3.Name = "numeric_3";
            this.numeric_3.Size = new System.Drawing.Size(70, 70);
            this.numeric_3.TabIndex = 7;
            this.numeric_3.Text = "3";
            this.numeric_3.UseVisualStyleBackColor = false;
            this.numeric_3.Click += new System.EventHandler(this.numeric_3_Click);
            // 
            // numeric_4
            // 
            this.numeric_4.BackColor = System.Drawing.Color.White;
            this.numeric_4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.numeric_4.FlatAppearance.BorderSize = 3;
            this.numeric_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numeric_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numeric_4.Location = new System.Drawing.Point(286, 19);
            this.numeric_4.Name = "numeric_4";
            this.numeric_4.Size = new System.Drawing.Size(70, 70);
            this.numeric_4.TabIndex = 6;
            this.numeric_4.Text = "4";
            this.numeric_4.UseVisualStyleBackColor = false;
            this.numeric_4.Click += new System.EventHandler(this.numeric_4_Click);
            // 
            // numeric_5
            // 
            this.numeric_5.BackColor = System.Drawing.Color.White;
            this.numeric_5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.numeric_5.FlatAppearance.BorderSize = 3;
            this.numeric_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numeric_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numeric_5.Location = new System.Drawing.Point(373, 19);
            this.numeric_5.Name = "numeric_5";
            this.numeric_5.Size = new System.Drawing.Size(70, 70);
            this.numeric_5.TabIndex = 5;
            this.numeric_5.Text = "5";
            this.numeric_5.UseVisualStyleBackColor = false;
            this.numeric_5.Click += new System.EventHandler(this.numeric_5_Click);
            // 
            // numeric_6
            // 
            this.numeric_6.BackColor = System.Drawing.Color.White;
            this.numeric_6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.numeric_6.FlatAppearance.BorderSize = 3;
            this.numeric_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numeric_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numeric_6.Location = new System.Drawing.Point(19, 118);
            this.numeric_6.Name = "numeric_6";
            this.numeric_6.Size = new System.Drawing.Size(70, 70);
            this.numeric_6.TabIndex = 4;
            this.numeric_6.Text = "6";
            this.numeric_6.UseVisualStyleBackColor = false;
            this.numeric_6.Click += new System.EventHandler(this.numeric_6_Click);
            // 
            // numeric_7
            // 
            this.numeric_7.BackColor = System.Drawing.Color.White;
            this.numeric_7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.numeric_7.FlatAppearance.BorderSize = 3;
            this.numeric_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numeric_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numeric_7.Location = new System.Drawing.Point(105, 118);
            this.numeric_7.Name = "numeric_7";
            this.numeric_7.Size = new System.Drawing.Size(70, 70);
            this.numeric_7.TabIndex = 3;
            this.numeric_7.Text = "7";
            this.numeric_7.UseVisualStyleBackColor = false;
            this.numeric_7.Click += new System.EventHandler(this.numeric_7_Click);
            // 
            // numeric_8
            // 
            this.numeric_8.BackColor = System.Drawing.Color.White;
            this.numeric_8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.numeric_8.FlatAppearance.BorderSize = 3;
            this.numeric_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numeric_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numeric_8.Location = new System.Drawing.Point(192, 118);
            this.numeric_8.Name = "numeric_8";
            this.numeric_8.Size = new System.Drawing.Size(70, 70);
            this.numeric_8.TabIndex = 2;
            this.numeric_8.Text = "8";
            this.numeric_8.UseVisualStyleBackColor = false;
            this.numeric_8.Click += new System.EventHandler(this.numeric_8_Click);
            // 
            // numeric_9
            // 
            this.numeric_9.BackColor = System.Drawing.Color.White;
            this.numeric_9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.numeric_9.FlatAppearance.BorderSize = 3;
            this.numeric_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numeric_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numeric_9.Location = new System.Drawing.Point(286, 118);
            this.numeric_9.Name = "numeric_9";
            this.numeric_9.Size = new System.Drawing.Size(70, 70);
            this.numeric_9.TabIndex = 1;
            this.numeric_9.Text = "9";
            this.numeric_9.UseVisualStyleBackColor = false;
            this.numeric_9.Click += new System.EventHandler(this.numeric_9_Click);
            // 
            // numeric_1
            // 
            this.numeric_1.BackColor = System.Drawing.Color.White;
            this.numeric_1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.numeric_1.FlatAppearance.BorderSize = 3;
            this.numeric_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numeric_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numeric_1.Location = new System.Drawing.Point(19, 19);
            this.numeric_1.Name = "numeric_1";
            this.numeric_1.Size = new System.Drawing.Size(70, 70);
            this.numeric_1.TabIndex = 0;
            this.numeric_1.Text = "1";
            this.numeric_1.UseVisualStyleBackColor = false;
            this.numeric_1.Click += new System.EventHandler(this.numeric_1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Location = new System.Drawing.Point(-9, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1295, 16);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Location = new System.Drawing.Point(0, 785);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1295, 16);
            this.panel4.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(-137, 379);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1600, 3);
            this.panel2.TabIndex = 8;
            // 
            // led
            // 
            this.led.BackColor = System.Drawing.Color.DodgerBlue;
            this.led.FlatAppearance.BorderSize = 0;
            this.led.Location = new System.Drawing.Point(988, 22);
            this.led.Name = "led";
            this.led.Size = new System.Drawing.Size(30, 20);
            this.led.TabIndex = 797;
            this.led.UseVisualStyleBackColor = false;
            this.led.Click += new System.EventHandler(this.led_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-137, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 3);
            this.panel1.TabIndex = 7;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NetDemo.Properties.Resources.KZ_logo_2022;
            this.pictureBox1.Location = new System.Drawing.Point(413, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button67
            // 
            this.button67.BackColor = System.Drawing.Color.White;
            this.button67.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button67.FlatAppearance.BorderSize = 0;
            this.button67.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button67.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button67.ForeColor = System.Drawing.Color.Black;
            this.button67.Image = ((System.Drawing.Image)(resources.GetObject("button67.Image")));
            this.button67.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button67.Location = new System.Drawing.Point(869, 12);
            this.button67.Name = "button67";
            this.button67.Size = new System.Drawing.Size(158, 97);
            this.button67.TabIndex = 165;
            this.button67.Text = " ";
            this.button67.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button67.UseVisualStyleBackColor = false;
            this.button67.Click += new System.EventHandler(this.button67_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.led);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button67);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KZ MEKATRONİK";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.Shown += new System.EventHandler(this.Login_Shown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button numeric_0;
        private System.Windows.Forms.Button numeric_2;
        private System.Windows.Forms.Button numeric_3;
        private System.Windows.Forms.Button numeric_4;
        private System.Windows.Forms.Button numeric_5;
        private System.Windows.Forms.Button numeric_6;
        private System.Windows.Forms.Button numeric_7;
        private System.Windows.Forms.Button numeric_8;
        private System.Windows.Forms.Button numeric_9;
        private System.Windows.Forms.Button numeric_1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button67;
        private System.Windows.Forms.Button led;
        private System.Windows.Forms.Panel panel1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}