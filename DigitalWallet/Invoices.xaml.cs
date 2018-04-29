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
using System.Data.SqlClient;

namespace DigitalWallet
{
      public partial class Invoices : Page
      {
            public Invoices()
            {
                  InitializeComponent();

            }
            private void fill_listBox()
            {
                  SqlConnection con = new SqlConnection(/*dillans db*/);
                  try
                  {
                        
                        con.Open();
                        string Query = "select * from Invoices ";
                        SqlCommand createcommand = new SqlCommand(Query, con);
                        SqlDataReader dr = createcommand.ExecuteReader();
                        while (dr.Read())
                        {
                              string InvoiceNo = dr.GetString(2);
                              string InvoiceID = dr.GetString(1);
                              invoicesListBox.Items.Add(InvoiceID + " " + InvoiceNo);
                        }
                        con.Close();
                  }
                  catch (Exception ex)
                  {
                        MessageBox.Show(ex.Message);

                  }

            }

            private void CreateInvoice_Click(object sender, RoutedEventArgs e)
            {
                  CreateInvoice createInvoice = new CreateInvoice();
                  NavigationService.Navigate(createInvoice);
            }

            private void UpdateInvoice_Click(object sender, RoutedEventArgs e)
            {
                  CreateInvoice createInvoice = new CreateInvoice();
                  NavigationService.Navigate(createInvoice);
            }

            private void PayInvoice_Click(object sender, RoutedEventArgs e)
            {
                  PayInvoice payInvoice = new PayInvoice();
                  NavigationService.Navigate(payInvoice);
            }

            private void Exit_Click(object sender, RoutedEventArgs e)
            {
                  MainMenuStudent mainMenuStudent = new MainMenuStudent();
                  NavigationService.Navigate(mainMenuStudent);

            }
      }
}


