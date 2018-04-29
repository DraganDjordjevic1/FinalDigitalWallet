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
    public partial class MainMenuStudent : Page
    {
        public MainMenuStudent()
        {
            InitializeComponent();
        }

        private void Account_Click(object sender, RoutedEventArgs e)
        {
            AccountStudent accountStudent = new AccountStudent();
            NavigationService.Navigate(accountStudent);
        }

        private void Invoices_Click(object sender, RoutedEventArgs e)
        {
            Invoices invoices = new Invoices();
            NavigationService.Navigate(invoices);

        }

        private void Profiles_Click(object sender, RoutedEventArgs e)
        {
            ProfilesStudent profilesStudent = new ProfilesStudent();
            NavigationService.Navigate(profilesStudent);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
