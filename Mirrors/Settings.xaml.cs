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
        }

        public void GetSettings()
        {
            settingsWindowMode.IsChecked = Properties.Settings.Default.WindowMode;
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
            if (settingsWindowMode.IsChecked == true)
            {
                Setting.ChangeSettings("WindowMode", 0x00000001);
            }
            else
            {
                Setting.ChangeSettings("WindowMode", 0x00000000);
            }
            Properties.Settings.Default.WindowMode = settingsWindowMode.IsEnabled;

            MessageBox.Show("Saved!");
        }

        private void Button_Exit(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
