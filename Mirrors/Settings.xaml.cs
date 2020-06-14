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
using MuOnline_Launcher_WPF.Classes;



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

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void Button_Settings_Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                ChangeResolution.ChangeSettings("WindowMode", 0x00000001);
            }
            catch (Exception a)
            {
                MessageBox.Show(Convert.ToString(a));
            }

        }

        private void CheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            try
            {
                ChangeResolution.ChangeSettings("WindowMode", 0x00000000);
            }
            catch (Exception a)
            {
                MessageBox.Show(Convert.ToString(a));
            }
        }



    }
}
