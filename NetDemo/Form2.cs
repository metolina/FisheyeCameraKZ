using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int newX = 416; // Yeni X koordinatı
            int newY = 95; // Yeni Y koordinatı

            // Formun konumunu güncelle
            this.Location = new Point(newX, newY);
            this.TopMost = true;
        }
    }
}
