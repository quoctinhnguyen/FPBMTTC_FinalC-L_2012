using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreeLayerDemo.Core;

namespace Client_FinalC_L
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
            //Application.Run(new Server());
            UserVO user = new UserVO("admin","kiet","a","a","123");
            MessageBox.Show(user.PassWord1);
        }
    }
}
