using MuOnline_Launcher_WPF.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace MuOnline_Launcher_WPF.Mirrors
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
            CheckBoxWinMode.IsChecked = Properties.Settings.Default.WinMod;
            ResolutionBox.SelectedIndex = Properties.Settings.Default.Resolution;
            CheckBoxMusicOnOff.IsChecked = Properties.Settings.Default.Music;
            CheckBoxSoundOnOff.IsChecked = Properties.Settings.Default.Sound;
            TextBoxAccount.Text = Properties.Settings.Default.Account;
            SliderVolumeLevel.Value = Properties.Settings.Default.VolumeLevel;
        }



        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void Button_Save(object sender, EventArgs e)
        {
            Properties.Settings.Default.WinMod = CheckBoxWinMode.IsChecked.Value;
            Properties.Settings.Default.Resolution = ResolutionBox.SelectedIndex;
            Properties.Settings.Default.Music = CheckBoxMusicOnOff.IsChecked.Value;
            Properties.Settings.Default.Sound = CheckBoxSoundOnOff.IsChecked.Value;
            Properties.Settings.Default.Account = TextBoxAccount.Text;
            Properties.Settings.Default.VolumeLevel = SliderVolumeLevel.Value;
            Properties.Settings.Default.Save();

            if (Properties.Settings.Default.WinMod == false)
            {
                switch (Properties.Settings.Default.Resolution)
                {
                    case 0:
                        Setting.ChangeSettings("Resolution", 0x00000001);
                        Setting.ChangeSettings("ResolutionA", 0x00000001);
                        Setting.ChangeSettings("WindowMode", 0x0000000);
                        break;
                    case 1:
                        Setting.ChangeSettings("Resolution", 0x00000002);
                        Setting.ChangeSettings("ResolutionA", 0x00000002);
                        Setting.ChangeSettings("WindowMode", 0x0000000);
                        break;
                    case 2:
                        Setting.ChangeSettings("Resolution", 0x00000003);
                        Setting.ChangeSettings("ResolutionA", 0x00000003);
                        Setting.ChangeSettings("WindowMode", 0x0000000);
                        break;
                }
            }
            else
            {
                switch (Properties.Settings.Default.Resolution)
                {
                    case 0:
                        Setting.ChangeSettings("Resolution", 0x00000001);
                        Setting.ChangeSettings("ResolutionA", 0x00000001);
                        Setting.ChangeSettings("WindowMode", 0x0000001);
                        break;
                    case 1:
                        Setting.ChangeSettings("Resolution", 0x00000002);
                        Setting.ChangeSettings("ResolutionA", 0x00000002);
                        Setting.ChangeSettings("WindowMode", 0x0000001);
                        break;
                    case 2:
                        Setting.ChangeSettings("Resolution", 0x00000003);
                        Setting.ChangeSettings("ResolutionA", 0x00000003);
                        Setting.ChangeSettings("WindowMode", 0x0000001);
                        break;
                }
            }

            if (Properties.Settings.Default.Music == false)
            {
                Setting.ChangeSettings("MusicOnOff", 0x00000000);
            }
            else
                Setting.ChangeSettings("MusicOnOff", 0x00000001);

            if (Properties.Settings.Default.Sound == false)
            {
                Setting.ChangeSettings("SoundOnOff", 0x00000000);
            }
            else
                Setting.ChangeSettings("SoundOnOff", 0x00000001);

            if (Properties.Settings.Default.Account != null)
            {
                Setting.ChangeSettings("ID", Properties.Settings.Default.Account);
            }

            switch (Properties.Settings.Default.VolumeLevel)
            {
                case 0.0:
                    Setting.ChangeSettings("VolumeLevel", 0x0000000);
                    break;
                case 1.0:
                    Setting.ChangeSettings("VolumeLevel", 0x0000001);
                    break;
                case 2.0:
                    Setting.ChangeSettings("VolumeLevel", 0x0000002);
                    break;
                case 3.0:
                    Setting.ChangeSettings("VolumeLevel", 0x0000003);
                    break;
                case 4.0:
                    Setting.ChangeSettings("VolumeLevel", 0x0000004);
                    break;
                case 5.0:
                    Setting.ChangeSettings("VolumeLevel", 0x0000005);
                    break;
            }


            this.Close();
        }

        private void Button_Exit(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
