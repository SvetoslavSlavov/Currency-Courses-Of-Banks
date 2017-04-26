using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_System_Svetoslav_Slavov_1501681032
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
            //за да разпознава точката
            Application.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("bg-BG");
            Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ".";
            Application.Run(new Form_Main());
        }
    }
}
