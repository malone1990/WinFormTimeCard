using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormTimeCard.Services;

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

            //Common.apiManager = ApiManager.GetManager();
            Common.apiManager = MockTimeCardRepo.GetManager();

            fmLogin frmLogin = new fmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                frmLogin.Close();
                Application.Run(new fmTimeCardMain());
            }
        }
    }
}
