using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DigitalWallet
{
      public partial class ProfilesTeacher : Page
      {
            public ProfilesTeacher()
            {
                  InitializeComponent();
                  fill_Listbox();
            }

            void fill_Listbox()
            {
                  SqlConnection con = new SqlConnection(/*dillans db*/);
                  try
                  {
                        
                        con.Open();
                        string Query = "select * from student ";
                        SqlCommand createcommand = new SqlCommand(Query, con);
                        SqlDataReader dr = createcommand.ExecuteReader();
                        while (dr.Read())
                        {
                              string studentID = dr.GetString(3);
                              string surname = dr.GetString(2);
                              string name = dr.GetString(1);
                              profileListBox.Items.Add(name + " " + surname + " " + studentID);
                        }
                        con.Close();
                  }
                  catch (Exception ex)
                  {
                        MessageBox.Show(ex.Message);
                        
                  }
                  


            }

            private void Exit_Click(object sender, RoutedEventArgs e)
            {
                  MainMenuTeacher mainMenuTeacher = new MainMenuTeacher();
                  NavigationService.Navigate(mainMenuTeacher);
            }

            private void SearchProfile_Click(object sender, RoutedEventArgs e)
            {

            }

            private void SearchAndSelectView_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {

            }

      }
}
