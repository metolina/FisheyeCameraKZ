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
            string username=txt_kullanici_adi.Text;
            string password = txt_sifre.Text;
            if (username=="admin" && password=="123")
            {
                NetDemo netDemo = new NetDemo();
                netDemo.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı yada Şifreniz Yanlış");
            }
        }
    }
}
