using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTextEditor
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        ///  Application by Jackie L.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Users userManager = new Users();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginScreen()); 
            Application.Exit();
        }
    }
}
