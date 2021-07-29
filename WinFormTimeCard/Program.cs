using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTimeCard
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //fmLogin frmLogin = new fmLogin();
            //if (frmLogin.ShowDialog() == DialogResult.OK)
            //{
            //    frmLogin.Close();
                Application.Run(new fmTimeCardMain());
            //}
        }
    }
}
