﻿namespace NetDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numeric_1 = new System.Windows.Forms.Button();
            this.numeric_9 = new System.Windows.Forms.Button();
            this.numeric_8 = new System.Windows.Forms.Button();
            this.numeric_7 = new System.Windows.Forms.Button();
            this.numeric_6 = new System.Windows.Forms.Button();
            this.numeric_5 = new System.Windows.Forms.Button();
            this.numeric_4 = new System.Windows.Forms.Button();
            this.numeric_3 = new System.Windows.Forms.Button();
            this.numeric_2 = new System.Windows.Forms.Button();
            this.numeric_0 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(375, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.Location = new System.Drawing.Point(495, 220);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(208, 38);
            this.txt_sifre.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(422, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 62);
            this.button1.TabIndex = 3;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NetDemo.Properties.Resources.KZ_logo_2022;
            this.pictureBox1.Location = new System.Drawing.Point(357, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(381, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 386);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şifre Arayüzü";
            this.groupBox1.Visible = false;
            // 
            // numeric_1
            // 
            this.numeric_1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.numeric_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numeric_1.Location = new System.Drawing.Point(46, 31);
            this.numeric_1.Name = "numeric_1";
            this.numeric_1.Size = new System.Drawing.Size(70, 70);
            this.numeric_1.TabIndex = 0;
            this.numeric_1.Text = "1";
            this.numeric_1.UseVisualStyleBackColor = false;
            // 
            // numeric_9
            // 
            this.numeric_9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.numeric_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numeric_9.Location = new System.Drawing.Point(252, 183);
            this.numeric_9.Name = "numeric_9";
            this.numeric_9.Size = new System.Drawing.Size(70, 70);
            this.numeric_9.TabIndex = 1;
            this.numeric_9.Text = "9";
            this.numeric_9.UseVisualStyleBackColor = false;
            // 
            // numeric_8
            // 
            this.numeric_8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.numeric_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numeric_8.Location = new System.Drawing.Point(152, 183);
            this.numeric_8.Name = "numeric_8";
            this.numeric_8.Size = new System.Drawing.Size(70, 70);
            this.numeric_8.TabIndex = 2;
            this.numeric_8.Text = "8";
            this.numeric_8.UseVisualStyleBackColor = false;
            // 
            // numeric_7
            // 
            this.numeric_7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.numeric_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numeric_7.Location = new System.Drawing.Point(46, 183);
            this.numeric_7.Name = "numeric_7";
            this.numeric_7.Size = new System.Drawing.Size(70, 70);
            this.numeric_7.TabIndex = 3;
            this.numeric_7.Text = "7";
            this.numeric_7.UseVisualStyleBackColor = false;
            // 
            // numeric_6
            // 
            this.numeric_6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.numeric_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numeric_6.Location = new System.Drawing.Point(252, 107);
            this.numeric_6.Name = "numeric_6";
            this.numeric_6.Size = new System.Drawing.Size(70, 70);
            this.numeric_6.TabIndex = 4;
            this.numeric_6.Text = "6";
            this.numeric_6.UseVisualStyleBackColor = false;
            // 
            // numeric_5
            // 
            this.numeric_5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.numeric_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numeric_5.Location = new System.Drawing.Point(152, 107);
            this.numeric_5.Name = "numeric_5";
            this.numeric_5.Size = new System.Drawing.Size(70, 70);
            this.numeric_5.TabIndex = 5;
            this.numeric_5.Text = "5";
            this.numeric_5.UseVisualStyleBackColor = false;
            // 
            // numeric_4
            // 
            this.numeric_4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.numeric_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numeric_4.Location = new System.Drawing.Point(46, 107);
            this.numeric_4.Name = "numeric_4";
            this.numeric_4.Size = new System.Drawing.Size(70, 70);
            this.numeric_4.TabIndex = 6;
            this.numeric_4.Text = "4";
            this.numeric_4.UseVisualStyleBackColor = false;
            // 
            // numeric_3
            // 
            this.numeric_3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.numeric_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numeric_3.Location = new System.Drawing.Point(252, 31);
            this.numeric_3.Name = "numeric_3";
            this.numeric_3.Size = new System.Drawing.Size(70, 70);
            this.numeric_3.TabIndex = 7;
            this.numeric_3.Text = "3";
            this.numeric_3.UseVisualStyleBackColor = false;
            // 
            // numeric_2
            // 
            this.numeric_2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.numeric_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numeric_2.Location = new System.Drawing.Point(152, 31);
            this.numeric_2.Name = "numeric_2";
            this.numeric_2.Size = new System.Drawing.Size(70, 70);
            this.numeric_2.TabIndex = 8;
            this.numeric_2.Text = "2";
            this.numeric_2.UseVisualStyleBackColor = false;
            // 
            // numeric_0
            // 
            this.numeric_0.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.numeric_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numeric_0.Location = new System.Drawing.Point(152, 259);
            this.numeric_0.Name = "numeric_0";
            this.numeric_0.Size = new System.Drawing.Size(70, 70);
            this.numeric_0.TabIndex = 9;
            this.numeric_0.Text = "0";
            this.numeric_0.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KZ MEKATRONİK";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
    }
}