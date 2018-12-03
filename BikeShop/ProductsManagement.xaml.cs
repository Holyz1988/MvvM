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

namespace BikeShop
{
    /// <summary>
    /// Interaction logic for ProductsManagement.xaml
    /// </summary>
    public partial class ProductsManagement : Page
    {
        ProductFactory products = new ProductFactory();

        public ProductsManagement()
        {
            InitializeComponent();

            dataGrd.ItemsSource = products.GetAllProducts();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var txtBox = sender as TextBox;
            dataGrd.ItemsSource = products.FindProducts(txtBox.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            brd.Background = new SolidColorBrush(Colors.BlueViolet);
        }
    }
}
