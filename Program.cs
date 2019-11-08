using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircusTrein
{
    static class Program
    {
        // TODO: Add Unit Tests
        // TODO: Small tweaks bbbb
        // TODO: Add that when clicking a Wagon in the listbox, it shows which animals are within it.

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CircusTrein());
        }
    }
}
