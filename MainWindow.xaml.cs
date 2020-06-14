using MuOnline_Launcher_WPF.Classes;
using MuOnline_Launcher_WPF.Mirrors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MuOnline_Launcher_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Settings(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            this.Visibility = Visibility.Visible;
            settings.Show();
        }

        private void Button_Play(object sender, EventArgs e)
        {
            if (!IsProcessOpen("main.exe"))
            {
                if (!File.Exists("main.exe"))
                {
                    MessageBox.Show("File Main.exe doesn't exist!");
                }
                else
                Process.Start("main.exe");
            }
            else
            {
                MessageBox.Show("You can start the game only once!");
            }
        }

        private void Windows_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        public bool IsProcessOpen(string name)
        {
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.Contains(name))
                {
                    return true;
                }
            }

            return false;
        }

    }
}
