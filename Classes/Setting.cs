using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;

namespace MuOnline_Launcher_WPF.Classes
{
    class Setting
    {
        private static string path = @"Software\Webzen\Mu\Config";

        public static void ChangeSettings<T>(string keyName, T value)
        {
            RegistryKey local = Registry.CurrentUser;


            var key = local.OpenSubKey(path, true);

            if (key == null)
            {
                local.CreateSubKey(path);
                MessageBox.Show("Try Again");
                local.Close();
            }
            else
            {
                switch (keyName)
                {

                    case "Resolution":
                        key.SetValue(keyName, value, RegistryValueKind.DWord);
                        key.SetValue(keyName + "A", value, RegistryValueKind.DWord);
                        break;
                    case "WindowMode":
                    case "VolumeLevel":
                    case "MusicOnOff":
                    case "SoundOnOff":
                        key.SetValue(keyName, value, RegistryValueKind.DWord);
                        break;

                    case "ID":
                        key.SetValue(keyName, value, RegistryValueKind.String);
                        break;
                }

                key.Close();
            }
        }
    }
}
