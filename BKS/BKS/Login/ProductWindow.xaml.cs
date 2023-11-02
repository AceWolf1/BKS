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
using System.Windows.Shapes;
using BKS.ClassHelper;

namespace BKS.Login
{
    /// <summary>
    /// Логика взаимодействия для ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        public ProductWindow()
        {
            InitializeComponent();
            GetListProduct();

        }
        public void GetListProduct()
        {

            Product.ItemsSource = ClassHelper.EF.Context.Product.ToList();
        }

        private void AddCart_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null)
            {
                return;
            }
            var productt = button.DataContext as DB.Product;

            productt.Quantity++;
            CartClass.prodCart.Add(productt);

        }
    }

}
