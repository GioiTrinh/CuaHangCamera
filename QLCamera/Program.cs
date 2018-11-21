using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCamera
{
    static class Program
    {
        public static bool _isSignedIn = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmBanHang());
            if(_isSignedIn)
                Application.Run(new FrmQLKH());
        }
    }
}
