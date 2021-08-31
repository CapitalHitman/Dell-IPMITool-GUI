using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dell_IPMITool_GUI
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
            String ipmiPath = Properties.Settings.Default.ipmiPath;
            Debug.WriteLine(Properties.Settings.Default.ipmiPath);
            Properties.Settings.Default.ipmiPath = "";
            Properties.Settings.Default.Save();
            if (ipmiPath == null || ipmiPath == "")
            {
                Application.Run(new directorySelector());
            }
            else if (ipmiPath != null)
            {
                Application.Run(new Connector());
            }
                
        }
    }
}
