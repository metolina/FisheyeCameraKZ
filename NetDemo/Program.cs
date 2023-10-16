using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NetDemo
{
    static class Program
    {
        /// <summary>
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form formToOpen = null;

            string configFilePath = "config.txt";

            if (File.Exists(configFilePath))
            {
                string lastOpenedForm = File.ReadAllText(configFilePath).Trim();

                if (!string.IsNullOrEmpty(lastOpenedForm) && lastOpenedForm=="1")
                {
                    Application.Run(new NetDemo());
                }
                else
                {
                    Application.Run(new Login()); // Başlangıç formu
                }
            }
            else
            {
                Application.Run(new Login()); // Başlangıç formu
            }

        }
       
    }
}
