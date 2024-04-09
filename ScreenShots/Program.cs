using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ScreenShots
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
//            Application.Run(new SekerHoze());
//            Application.Run(new Form1());
            Application.Run(new Hazmana());
//            Application.Run(new SingleResultEntry());
//            Application.Run(new MultiResultEntry());
//            Application.Run(new Validation());
        }
    }
}
