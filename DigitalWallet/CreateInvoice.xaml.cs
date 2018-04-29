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
      /// <summary>
      /// Interaction logic for CreateInvoice.xaml
      /// </summary>
      public partial class CreateInvoice : Page
      {
            public CreateInvoice()
            {
                  InitializeComponent();
            }

            private void SaveInvoice_Click(object sender, RoutedEventArgs e)
            {
                  SqlConnection con = new SqlConnection(/* Dillans database */);
                  try
                  {
                        con.Open();
                        string Query = "insert into InvoiceCreation (firstname, lastname, age, address, InvoiceNo, InvoiceID) values('" + this.firstName.Text + "', '" + this.lastName.Text + "', '" + this.age.Text + "', '" + this.address.Text + "', '" + this.invoice.Text + "', '" + this.invoiceID.Text + "')";
                        SqlCommand createcommand = new SqlCommand(Query, con);
                        createcommand.ExecuteNonQuery();
                        MessageBox.Show("Invoice has been paid");
                        con.Close();
                        Invoices invoices = new Invoices();
                        NavigationService.Navigate(invoices);

                  }
                  catch (Exception ex)
                  {
                        MessageBox.Show(ex.Message);

                  }
                  

            }

            private void Exit_Click(object sender, RoutedEventArgs e)
            {
                  Invoices invoices = new Invoices();
                  NavigationService.Navigate(invoices);
            }
      }
}
