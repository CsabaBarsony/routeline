using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace RouteLineUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            string[] settings = config.AppSettings.Settings.AllKeys;
            bool contains = settings.Contains("registered");

            if (contains)
            {
                Application.Run(new Form1());
            }
            else
            {
                Application.Run(new FormAuth());
            }
        }
    }
}
