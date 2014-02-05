using System;
using System.Windows.Forms;

namespace RandomMapGenerator
{
    internal static class RandomMapGenerator
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //TODO use unity to resolve this
            var processModel = new ProcessModel();

            Application.Run(new UserOptionsForm(processModel));
        }
    }
}