using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetDemo
{
    public partial class Form3 : Form
    {
        public Form3()
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
            string password = LoadPassword();
            if (textBox1.Text==password)
            {
                if (textBox2.Text!=textBox3.Text)
                {
                    MessageBox.Show("Güncel Şifreyi Hatalı Girdiniz");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    return;
                }
                SavePassword(textBox2.Text);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                MessageBox.Show("Şifreniz Güncellenmiştir");
                this.Close();
            }
            else
            {
                MessageBox.Show("Eski Şifreyi Hatalı Girdiniz");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }
    }
}
