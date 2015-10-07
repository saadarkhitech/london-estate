using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace London_Estate
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FController fobj = new FController();
            fobj.addPlaza("test", 3, 3, 3, "basb", "isb");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main());
        }
    }
}
