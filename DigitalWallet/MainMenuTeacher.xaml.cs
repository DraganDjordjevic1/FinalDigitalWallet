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

namespace DigitalWallet
{
    public partial class MainMenuTeacher : Page
    {
        public MainMenuTeacher()
        {
            InitializeComponent();
        }

        private void ManageAccount_Click(object sender, RoutedEventArgs e)
        {
            AccountTeacher accountTeacher = new AccountTeacher();
            NavigationService.Navigate(accountTeacher);
        }

        private void Profiles_Click(object sender, RoutedEventArgs e)
        {
            ProfilesTeacher profilesTeacher = new ProfilesTeacher();
            NavigationService.Navigate(profilesTeacher);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
