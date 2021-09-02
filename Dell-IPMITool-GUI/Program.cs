using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Net;
using CliWrap;
using CliWrap.Buffered;

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
            errorPopup.errorTextBox.Height = errorTextSize.Height * lineCount;
            Size initialSize = errorPopup.Size;
            errorPopup.Size = new Size(initialSize.Width, initialSize.Height + errorPopup.errorTextBox.Height - 20);
            errorPopup.errorTextBox.SelectionAlignment = HorizontalAlignment.Center;
            Program.log(errorPopup.errorTextBox.Text);
            errorPopup.Show();
        }

        public static void validateIP(String ipString)
        {
            //IP address input validation
            IPAddress ip = null;

            if(String.IsNullOrWhiteSpace(ipString) || String.Equals(ipString,  ""))
            {
                errorPopup("IP field cannot be empty");
                return;
            }
            string[] splitIP = ipString.Split('.');
            if (splitIP.Length != 4  || !IPAddress.TryParse(ipString, out ip))
            {
                Program.errorPopup("IP Address is not valid. Please enter a valid IP Address");
            }
            if (ip == null)
            {
                Program.log("Entered IP Address was parsed as: NULL");
            }
            else if (ip != null)
            {
                Program.log("Entered IP Address was parsed as: " + ip);
            }
        }

        public static void validateUsername(String username)
        {
            //Username input validation
            if (String.IsNullOrEmpty(username) || String.IsNullOrWhiteSpace(username))
            {
                errorPopup("Username is blank or null. Please enter a username.");
            }

        }

        public static void validatePassword(String password)
        {
            //Username input validation
            if (String.IsNullOrEmpty(password) || String.IsNullOrWhiteSpace(password))
            {
                errorPopup("Password is blank or null. Please enter a password.");
            }

        }

        public static async Task<string> commandExecuteAsync(String command)
        {
            string workingDir = Directory.GetCurrentDirectory();
            var result = await Cli.Wrap(Properties.Settings.Default.ipmiPath)
                .WithArguments(command)
                .WithWorkingDirectory(workingDir)
                .ExecuteBufferedAsync();
            return result.StandardOutput;
        }
    }
}
