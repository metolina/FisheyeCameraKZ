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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var list = ListMp4Files(Application.StartupPath + "\\Record");
            foreach (var item in list)
            {
                listBox1.Items.Add(item);
            }
            vlcControl1.VlcLibDirectory = new DirectoryInfo(@"C:\Program Files\VideoLAN\VLC");
            vlcControl1.VlcMediaplayerOptions = new[] { "--no-xlib" };
            vlcControl1.BeginInit();
            vlcControl1.EndInit();
        }
        public List<string> ListMp4Files(string folderPath)
        {

            List<string> mp4Files = new List<string>();
            DirectoryInfo directory = new DirectoryInfo(folderPath);
            foreach (FileInfo file in directory.GetFiles("*.jpg"))
            {
                mp4Files.Add(file.Name);
            }
            return mp4Files;
        }
        private void listBox1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedFile = Application.StartupPath + "\\Record\\" + listBox1.SelectedItem.ToString();
                vlcControl1.SetMedia(new FileInfo(selectedFile));
                vlcControl1.Play();
            }
        }
    }
}
