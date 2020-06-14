using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace MuOnline_Launcher_WPF.Classes
{
    class ChangeResolution
    {
        private static string path = @"Software\Webzen\Mu\Config";

        public static void ChangeSettings(string keyName, UInt32 value)
        {
            RegistryKey key = Registry.CurrentUser; // OUR REGISTERY KEY
            key = key.OpenSubKey(path, true);
            switch (keyName)
            {
                case "Resolution":
                    key.SetValue(keyName, value, RegistryValueKind.DWord);
                    key.SetValue(keyName+"A", value, RegistryValueKind.DWord);
                    key.Close();
                    break;
                case "WindowMode":
                    key.SetValue(keyName, value, RegistryValueKind.DWord);
                    key.Close();
                    break;

                case "VolumeLevel":
                    key.SetValue(keyName, value, RegistryValueKind.DWord);
                    key.Close();
                    break;
            }

        }

    }
}
