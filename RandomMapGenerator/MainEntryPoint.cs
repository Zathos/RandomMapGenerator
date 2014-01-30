using System;
using System.Windows.Forms;

namespace RandomMapGenerator
{
    internal static class MainEntryPoint
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserOptionsForm());
        }
    }
}