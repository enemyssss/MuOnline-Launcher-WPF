using MuOnline_Launcher_WPF.Classes;
using MuOnline_Launcher_WPF.Mirrors;
using System;
using System.Collections.Generic;
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

            List<Character> CharacterList = new List<Character>();
            List<Guild> GuildList = new List<Guild>();

            CharacterList.Add(new Character(1, "Icarus", 400, 25, 1));

            GuildList.Add(new Guild(1, "Krust", 5, 155));
            GuildList.Add(new Guild(2, "Pobeda", 5, 45));
            GuildList.Add(new Guild(3, "Ataka", 3, 51));
            GuildList.Add(new Guild(4, "Moshtni", 1, 34));

            CharacterRanking.ItemsSource = CharacterList;
            GuildRanking.ItemsSource = GuildList;
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

        private void Windows_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
