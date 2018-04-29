using System;
using System.Collections.Generic;
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

namespace DigitalWallet
{
      public partial class ProfilesStudent : Page
      {
            public ProfilesStudent()
            {
                  InitializeComponent();

            }

            private void SearchProfile_Click(object sender, RoutedEventArgs e)
            {

            }

            private void Exit_Click(object sender, RoutedEventArgs e)
            {
                  MainMenuStudent mainMenuStudent = new MainMenuStudent();
                  NavigationService.Navigate(mainMenuStudent);
            }
      }

    /*  public class Product
      {
            public string Name
            {
                  get;
                  set;
            }
      }
      public class SearchAndSelectViewModel
      {

            private ICollectionView products;

            private Product selectedProduct;



            public SearchAndSelectViewModel()
            {

                  var myProducts = new List<Product>();


                  this.products = CollectionViewSource.GetDefaultView(myProducts);
                  this.products.Filter = NameContainsA;
            }

            public ICollectionView Products
            {
                  get
                  {
                        return this.products;
                  }
            }

            public Product SelectedProduct
            {
                  get
                  {
                        return this.selectedProduct;
                  }
                  set
                  {
                        if (this.selectedProduct != value)
                        {
                              this.selectedProduct = value;
                        }
                  }
            }
            public bool NameContainsA(object item)
            {
                  var product = item as Product;
                  if (product == null)
                  {
                        return false;
                  }

                  return product.Name.ToUpperInvariant().Contains("A");
            }

            private string filter;

            public string Filter
            {
                  get
                  {
                        return this.filter.ToUpperInvariant();
                  }
                  set
                  {
                        if (this.filter != value)
                        {
                              this.filter = value;
                              this.Products.Refresh();
                        }
                  }
            }

            private bool ContainsFilter(object item)
            {
                  var product = item as Product;
                  if (product == null)
                  {
                        return false;
                  }

                  if (string.IsNullOrEmpty(this.Filter))
                  {
                        return true;
                  }

                  if (product.Name.ToUpperInvariant().Contains(this.Filter))
                  {
                        return true;
                  }

                  return false;
            }
      }
      */
}
