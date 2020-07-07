using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media.Imaging;
using System.Xml;

namespace MuOnline_Launcher_WPF.Classes
{
    public class WebCommunication
    {
        private static string StatusBarImg = null;

        public static string Read(string WebAdress)
        {
            using (WebClient client = new WebClient())
            {
            return  client.DownloadString(WebAdress);
            }
        }

    }
}
