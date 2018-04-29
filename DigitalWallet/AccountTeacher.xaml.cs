using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
      /// Interaction logic for AccountTeacher.xaml
      /// </summary>
      public partial class AccountTeacher : Page
      {

            public AccountTeacher()
            {
                  InitializeComponent();
            }

            private void CreateAccount_Click(object sender, RoutedEventArgs e)
            {
                  CreateEditAccount createEditAccount = new CreateEditAccount();
                  NavigationService.Navigate(createEditAccount);
            }

            private void EditAccount_Click(object sender, RoutedEventArgs e)
            {
                  CreateEditAccount createEditAccount = new CreateEditAccount();
                  NavigationService.Navigate(createEditAccount);
            }

            private void DeleteAccount_Click(object sender, RoutedEventArgs e)
            {
                  accountdata.Items.RemoveAt(accountdata.Items.IndexOf(accountdata.SelectedItem));
            }

            private void Exit_Click(object sender, RoutedEventArgs e)
            {
                  MainMenuTeacher mainMenuTeacher = new MainMenuTeacher();
                  NavigationService.Navigate(mainMenuTeacher);
            }

            private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
            {

            }
      }
}
