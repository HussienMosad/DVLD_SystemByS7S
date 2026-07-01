using DVLD.More;
using DVLD_BusinessLayer;
using DVLD.Users.Forms.SecondryForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            while (ClsGlobal.CurrentUser == null && FrmLoginScreen.CloseApp == false)
            {
                Application.Run(new FrmLoginScreen());
                if (!(ClsGlobal.CurrentUser == null))
                {
                    
                    Application.Run(new FrmHome());
                }
            }
        }
    }
}
