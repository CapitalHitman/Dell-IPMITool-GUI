using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dell_IPMITool_GUI
{
    class TabData
    {
        public string ip { get; }
        public string username { get; }
        public string password { get; }

        public TabData(String ip, String username, String password)
        {
            this.ip = ip;
            this.username = username;
            this.password = password;
        }

    }
}
