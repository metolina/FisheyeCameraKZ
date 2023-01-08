using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetDemo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string password = txt_sifre.Text;
            if (password=="123")
            {
                button1.BackColor = Color.ForestGreen;
                button1.ForeColor = Color.White;
                groupBox1.Visible = false;
                NetDemo netDemo = new NetDemo();
                netDemo.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı yada Şifreniz Yanlış");
                txt_sifre.Text = "";
            }
        }

        private void txt_sifre_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }
        #region Bankamatik Tuşları
        private void numeric_1_Click(object sender, EventArgs e)
        {
            txt_sifre.Text += "1";
        }

        private void numeric_2_Click(object sender, EventArgs e)
        {
            txt_sifre.Text += "2";
        }

        private void numeric_3_Click(object sender, EventArgs e)
        {
            txt_sifre.Text += "3";
        }

        private void numeric_4_Click(object sender, EventArgs e)
        {
            txt_sifre.Text += "4";
        }

        private void numeric_5_Click(object sender, EventArgs e)
        {
            txt_sifre.Text += "5";
        }

        private void numeric_6_Click(object sender, EventArgs e)
        {
            txt_sifre.Text += "6";
        }

        private void numeric_7_Click(object sender, EventArgs e)
        {
            txt_sifre.Text += "7";
        }

        private void numeric_8_Click(object sender, EventArgs e)
        {
            txt_sifre.Text += "8";
        }

        private void numeric_9_Click(object sender, EventArgs e)
        {
            txt_sifre.Text += "9";
        }

        private void numeric_0_Click(object sender, EventArgs e)
        {
            txt_sifre.Text += "0";
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_sifre.Text == "") return;
            
            txt_sifre.Text = txt_sifre.Text.Substring(0, txt_sifre.Text.Length - 1);
        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
