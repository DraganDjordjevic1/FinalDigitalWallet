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

namespace DigitalWallet
{
      public partial class CreateEditAccount : Page
      {
            public CreateEditAccount()
            {
                  InitializeComponent();
            }


            private void Exit_Click(object sender, RoutedEventArgs e)
            {
                  AccountTeacher accountTeacher = new AccountTeacher();
                  NavigationService.Navigate(accountTeacher);
            }


            private void CreateAccount_Click(object sender, RoutedEventArgs e)
            {
                  SqlConnection con = new SqlConnection(/*dillans db*/);
                  try
                  {
                        con.Open();
                        string Query = "insert into Student (firstname, lastname, age, address, city, state) values('" + this.firstName.Text + "', '" + this.lastName.Text + "', '" + this.age.Text + "', '" + this.address.Text + "' , '" + this.city.Text + "', '" + this.state.Text + "')";
                        SqlCommand createcommand = new SqlCommand(Query, con);
                        createcommand.ExecuteNonQuery();
                        MessageBox.Show("Account has been created");
                        con.Close();
                        Invoices invoices = new Invoices();
                        NavigationService.Navigate(invoices);
                  }
                  catch (Exception ex)
                  {
                        MessageBox.Show(ex.Message);

                  }
            }
      }
}
