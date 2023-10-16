using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NetDemo
{
    static class Program
    {
        /// <summary>
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form formToOpen = null;

            if (args.Length > 0)
            {
                if (args[0] == "NetDemo")
                {
                    formToOpen = new NetDemo();
                }
            }

            if (formToOpen == null)
            {
                formToOpen = new Login();
            }

            Application.Run(formToOpen);
        }
       
    }
}
