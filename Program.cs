using System;
using System.Windows.Forms;

namespace Farsight
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
            LCUInterface lCUInterface = new LCUInterface();
            mainScreen Parent = new mainScreen();
            Application.Run(Parent);
        }
    }
}
