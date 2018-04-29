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
    /// <summary>
    /// Interaction logic for AccountStudent.xaml
    /// </summary>
    public partial class AccountStudent : Page
    {
        public AccountStudent()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainMenuStudent mainMenuStudent = new MainMenuStudent();
            NavigationService.Navigate(mainMenuStudent);
        }
    }
}
