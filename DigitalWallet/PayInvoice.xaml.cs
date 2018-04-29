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
      public partial class PayInvoice : Page
      {
            public PayInvoice()
            {
                  InitializeComponent();
            }
            SqlConnection con = new SqlConnection(/* Dillans database */);

            private void ConfirmPayment_Click(object sender, RoutedEventArgs e)
            {
                  try
                  {
                        con.Open();
                        string Query = "insert into Invoice (accountNo, PaymentAmount, InvoiceNo, InvoiceDescription) values('" + this.accountNo.Text + "', '" + this.paymentAmmount.Text + "', '" + this.invoicetNo.Text + "', '" + this.invoiceDescription.Text + "')";
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

            private void paymentAmmount_TextChanged(object sender, TextChangedEventArgs e)
            {

            }
      }
}
