using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NetDemo
{
    public partial class Login : Form
    {
       
       
        public Login()
        {
            InitializeComponent();

            

        }
        #region Şifreleme İşlemleri

        private const string passwordtxtPathName = "password.json";

        private static string GetDosyaYolu()
        {
            return Path.Combine(Application.LocalUserAppDataPath, passwordtxtPathName);
        }

        public static string LoadPassword()
        {
            string dosyaYolu = GetDosyaYolu();
            if (File.Exists(dosyaYolu))
            {
                string json = File.ReadAllText(dosyaYolu);
                return JsonConvert.DeserializeObject<string>(json);
            }
            else
            {
                // Dosya yoksa varsayılan bir şifre nesnesi oluştur ve kaydet
                var defaultPassword = "123";
                SavePassword(defaultPassword);
                return defaultPassword;
            }
        }

        public static void SavePassword(string password)
        {
            string dosyaYolu = GetDosyaYolu();

            try
            {
                string json = JsonConvert.SerializeObject(password);
                File.WriteAllText(dosyaYolu, json);
            }
            catch (Exception ex)
            {
                // Dosya yazma hatası yakalama işlemi
                MessageBox.Show("Şifre kaydedilirken bir hata oluştu: " + ex.Message);
            }
        }

        #endregion
         
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Giriş İçin Tıklayınız")
            {
                button1.Text = "Giriş Yap";
                groupBox1.Visible = true;
            }
            else
            {
                string password = txt_sifre.Text;
                if (password == LoadPassword())
                {
                    if (serialPort1.IsOpen == true)
                    {
                        serialPort1.Close();
                    }
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
        }

        private void txt_sifre_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            if (button1.Text == "Giriş İçin Tıklayınız")
            {
                button1.Text = "Giriş Yap";
            }
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

        private void SaveSettings2()
        {
            try
            {
                DateTime now = DateTime.Now;
                using (StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Settings\\config2.dat"))
                {
                    sw.WriteLine(0);
                }

            }
            catch (Exception)
            {

            }
        }
        private void LoadSettings()
        {
        
            try
            {

                string fName = Application.StartupPath + "\\Settings\\Config2.dat";
                if (File.Exists(fName))
                {
                    string[] lines = File.ReadAllLines(fName);
                    try
                    {

                        string denem = lines[0];

                        if(denem=="1")
                        {
                            SaveSettings2();
                            if (serialPort1.IsOpen == true)
                            {
                                serialPort1.Close();
                            }
                            //button1.BackColor = Color.ForestGreen;
                            //button1.ForeColor = Color.White;
                            groupBox1.Visible = false;
                            NetDemo netDemo = new NetDemo();



                          
                            this.Hide();
                            netDemo.Show();
                        }
                        else
                        {
                            this.Show();
                        }
               

                    }
                    catch (Exception ex)
                    {
                        //System.IO.File.Delete(fName);
                    }

                }
            }
            catch (Exception ex) { }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen == true)
                {
                    serialPort1.Close();
                }
                string port = "";
                string baudrate = "";
                string fName = Application.StartupPath + "\\Settings\\Config.dat";
                if (File.Exists(fName))
                {
                    string[] lines = File.ReadAllLines(fName);
                    try
                    {

                        port = lines[0];
                        baudrate = lines[1];

                    }
                    catch (Exception ex)
                    {
                        //System.IO.File.Delete(fName);
                    }
                    serialPort1.PortName = port;
                    serialPort1.BaudRate = Convert.ToInt32(baudrate);
                    serialPort1.Open();
                }
            }
            catch
            {

            }

            string configFilePath = "config.txt";
            string contentToWrite = "0";
            File.WriteAllText(configFilePath, contentToWrite);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button67.Text = DateTime.Now.ToLongTimeString();
            led.BackColor = led.BackColor==Color.DodgerBlue ? Color.White : Color.DodgerBlue;
        }

        private void led_Click(object sender, EventArgs e)
        {

        }

        private void button67_Click(object sender, EventArgs e)
        {

        }



        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(100);
            try
            {

                string dataCom = serialPort1.ReadExisting();       // bufferdan verileri oku
                string[] vals;

                if (dataCom.Length > 94)
                {

                    vals = dataCom.Split(',');
                    if (Convert.ToString(vals[80]).ToString() == "1")
                    {

                        if (serialPort1.IsOpen == true)
                        {
                            serialPort1.Write("100");
                        }

                        Thread.Sleep(1000);
                        serialPort1.Close();
                        System.Diagnostics.Process.Start("shutdown", "/s /t 0");
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void Login_Shown(object sender, EventArgs e)
        {
             // LoadSettings();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
