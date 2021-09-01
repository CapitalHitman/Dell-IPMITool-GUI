using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Dell_IPMITool_GUI
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            File.WriteAllText("log.txt", String.Empty);
            log("Log cleared on application start");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); 
            String ipmiPath = Properties.Settings.Default.ipmiPath;
            Debug.WriteLine(Properties.Settings.Default.ipmiPath);

            /// Used to sanitize ipmiPath variable while testing(resets it to null).
            Properties.Settings.Default.ipmiPath = String.Empty;
            Properties.Settings.Default.Save();

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

        public static void log(Object loggedObject)
        {
            using (StreamWriter writer = File.AppendText("log.txt"))
            {
                AppendLog(loggedObject, writer);
            }
        }

        public static void AppendLog(Object loggedObject, TextWriter writer)
        {
            writer.Write(DateTime.Now.ToString("MM/dd/yyyy h:mm:ss:fff tt: ") + loggedObject + System.Environment.NewLine);
            Debug.WriteLine(loggedObject);
        }

        ///Used to create a dynamic error popup.
        public static void errorPopup(object errorObject)
        {
            Popups.errorPopup errorPopup = new Popups.errorPopup();
            errorPopup.errorTextBox.Text = errorObject.ToString();
            Size errorTextSize = TextRenderer.MeasureText(errorPopup.errorTextBox.Text, errorPopup.errorTextBox.Font);
            int lineCount = errorPopup.errorTextBox.GetLineFromCharIndex(errorPopup.errorTextBox.Text.Length - 1) + 1;
            errorPopup.errorTextBox.Height = errorTextSize.Height*lineCount;
            Size initialSize = errorPopup.Size;
            errorPopup.Size = new Size(initialSize.Width, initialSize.Height + errorPopup.errorTextBox.Height - 20);
            errorPopup.errorTextBox.SelectionAlignment = HorizontalAlignment.Center;
            Program.log(errorPopup.errorTextBox.Text);
            errorPopup.Show();
        }

    }
}
