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

            /// Used to sanitize ipmiPath variable while testing(resets it to null).
            //Properties.Settings.Default.ipmiPath = String.Empty;
            //Properties.Settings.Default.Save();

            /// Checks to see if the user has selected the file path for their ipmitool.exe. If they have not it presents them with the file path selector. If they have it presents them with the connector.
            if (ipmiPath == null || ipmiPath == "" || !ipmiPath.Contains("ipmitool.exe"))
            {
                Application.Run(new directorySelector());
            }
            else if (ipmiPath != null && ipmiPath.Contains("ipmitool.exe"))
            {
                Application.Run(new Connector());
            }
                
        }
    }
}
