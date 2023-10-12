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
   
    public partial class Form1 : Form
    {
        //Class1 cls;
        int bbbb = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public string[] Form2y = {"1","1","0"};
        private void Form1_Load(object sender, EventArgs e)
        {
            // Formun yeni konumunu belirle
            int newX = 372; // Yeni X koordinatı
            int newY = 95; // Yeni Y koordinatı

            // Formun konumunu güncelle
            this.Location = new Point(newX, newY);
            //cls = new Class1();
            //this.Opacity = 1;
            this.TopMost = true;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string[] vals = SharedDataSingleton.Instance.SharedData;

                if (vals != null && vals.Length >= 96)
                {
                    //LblB1.Text = receivedData[0] + receivedData[1] + receivedData[2];

                    LblB1.Text = Convert.ToString(vals[43]).ToString();
                    LblB2.Text = Convert.ToString(vals[50]).ToString();
                    LblB3.Text = Convert.ToString(vals[57]).ToString();
                    LblB4.Text = Convert.ToString(vals[64]).ToString();

                    if (vals.Length > 96)
                    {
                        string alici1 = vals[38] + vals[39] + vals[40] + vals[41];
                        LblAlici1.Text = alici1; 
                    
                        string alici2 = vals[45] + vals[46] + vals[47] + vals[48];
                        LblAlici2.Text = alici2; 
                       

                        string alici3 = vals[52] + vals[53] + vals[54] + vals[55];
                        LblAlici3.Text = alici3; 
                       
                        string alici4 = vals[59] + vals[60] + vals[61] + vals[62];
                        LblAlici4.Text = alici4; 
                       

                        if (Convert.ToString(vals[43]).ToString() == "0")
                        {
                            Durum1.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\red.png");
                            LblF1.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\red.png");
                            LblS1.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\red.png");
                        }

                        else Durum1.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\green.png");

                        if (Convert.ToString(vals[50]).ToString() == "0")
                        {
                            Durum2.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\red.png");
                            LblF2.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\red.png");
                            LblS2.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\red.png");
                        }
                        else Durum2.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\green.png");


                        if (Convert.ToString(vals[57]).ToString() == "0")
                        {
                            Durum3.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\red.png"); ;
                            LblF3.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\red.png");
                            LblS3.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\red.png");
                        }
                        else Durum3.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\green.png");


                        if (Convert.ToString(vals[64]).ToString() == "0")
                        {
                            Durum4.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\red.png");
                            LblF4.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\red.png");
                            LblS4.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\red.png");
                        }
                        else Durum4.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\green.png");

                        if (Convert.ToString(vals[44]).ToString() == "72")//H
                        {
                            LblF1.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\red.png");
                            LblS1.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\red.png");
                        }

                        else if (Convert.ToString(vals[44]).ToString() == "70")//FF
                        {
                            LblF1.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\green.png");
                            LblS1.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\red.png");
                        }
                        else if (Convert.ToString(vals[44]).ToString() == "69")//E
                        {
                            LblF1.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\green.png");
                            LblS1.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\green.png");
                        }


                        if (Convert.ToString(vals[51]).ToString() == "72")
                        {
                            LblF2.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\red.png");
                            LblS2.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\red.png");
                        }

                        else if (Convert.ToString(vals[51]).ToString() == "70")
                        {
                            LblF2.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\green.png");
                            LblS2.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\red.png");
                        }
                        else if (Convert.ToString(vals[51]).ToString() == "69")
                        {
                            LblF2.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\green.png");
                            LblS2.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\green.png");
                        }

                        if (Convert.ToString(vals[58]).ToString() == "72")
                        {
                            LblF3.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\red.png");
                            LblS3.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\red.png");
                        }

                        else if (Convert.ToString(vals[58]).ToString() == "70")
                        {
                            LblF3.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\green.png");
                            LblS3.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\red.png");
                        }
                        else if (Convert.ToString(vals[58]).ToString() == "69")
                        {
                            LblF3.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\green.png");
                            LblS3.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\green.png");
                        }

                        if (Convert.ToString(vals[65]).ToString() == "72")
                        {
                            LblF4.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\red.png");
                            LblS4.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\red.png");
                        }

                        else if (Convert.ToString(vals[65]).ToString() == "70")
                        {
                            LblF4.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\green.png");
                            LblS4.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\red.png");
                        }
                        else if (Convert.ToString(vals[65]).ToString() == "69")
                        {
                            LblF4.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\green.png");
                            LblS4.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Settings\\green.png");
                        }

                    }
                }
            }
            catch(Exception ex)
            {
                //timer1.Enable = true;
            }
        }
    }
}
