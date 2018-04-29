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
using System.Data.SqlClient;
using System.Data;


namespace DigitalWallet
{
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
                 SqlConnection con = new SqlConnection(/* Dillans database */);
                  /* try
                   {
                         if (con.State == ConnectionState.Closed)
                               con.Open();
                         String query = "SELECT COUNT(1) FROM Login WHERE Username=@Username AND Password=@Password";
                         SqlCommand sqlcmd = new SqlCommand(query, con);
                         sqlcmd.CommandType = CommandType.Text;
                         sqlcmd.Parameters.AddWithValue("@Username", username.Text);
                         sqlcmd.Parameters.AddWithValue("@Password", password.Text);
                         int count = Convert.ToInt32(sqlcmd.ExecuteScalar());
                         if (count == 1)
                         {

                               MainMenuTeacher mmt = new MainMenuTeacher();
                               NavigationService.Navigate(mmt);

                         }
                         else
                         {
                               MessageBox.Show("Username or Password is incorrect.");
                         }
                   }
                   catch (Exception ex)
                   {

                         MessageBox.Show(ex.Message);
                   }
                   finally
                   {
                         con.Close();
                   }
           */
                  if (username.Text == "student" || password.Text == "student")
                  {
                        MainMenuStudent mms = new MainMenuStudent();
                        MainMenuTeacher mmt = new MainMenuTeacher();
                        NavigationService.Navigate(mmt);
                  }
            }

      
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
