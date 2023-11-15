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
using System.Windows.Shapes;
using BKS.DB;

using BKS.ClassHelper; 

namespace BKS.Login
{
    /// <summary>
    /// Логика взаимодействия для CorzinaWindow.xaml
    /// </summary>
    public partial class CorzinaWindow : Window
    {
        public CorzinaWindow()
        {
            InitializeComponent();
            GetListCart();
        }
        private void GetListCart()
        {
            //CartWin.ItemsSource = CartClass.prodCart.ToList();

            ObservableCollection <DB.Product> listCart = new ObservableCollection <DB.Product>(ClassHelper.CartClass.prodCart);
            CartWin.ItemsSource = listCart.Distinct();


        }


        private void Plas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddCart_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ProductWindow productWindow = new ProductWindow();
            productWindow.Show();
        }

        private void PayBtn_Click(object sender, RoutedEventArgs e)
        {
            DB.Sales order = new DB.Sales();
            order.SaleDate = DateTime.Now;
            order.StaffId = 1;
            EF.Context.Sales.Add(order);
            //EF.context.Order.Add(order);
            EF.Context.SaveChanges();

            foreach (var item in CartClass.prodCart.Distinct())
            {
                ProductSale productOrder = new ProductSale();
                productOrder.SaleID = order.Id;
                productOrder.ProductId = item.Id;
                productOrder.Quantity = item.Quantity;

                EF.Context.ProductSale.Add(productOrder);
                EF.Context.SaveChanges();
            }

            MessageBox.Show("Заказ успешно оформлен");

            GetListCart();

        }

        private void deleteBTN_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            if (button == null)
            {
                return;
            }
            var product = button.DataContext as DB.Product;

            CartClass.prodCart.Remove(product);

            product.Quantity = 0;

            GetListCart();

        }

        private void MinusBTN_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            if (button == null)
            {
                return;
            }
            var product = button.DataContext as DB.Product;

            if (product.Quantity > 1)
            {
                product.Quantity--;

                GetListCart();
            }
            GetListCart();

        }

        private void PlusBTN_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            if (button == null)
            {
                return;
            }
            var product = button.DataContext as DB.Product;

            if (product.Quantity < 20)
            {
                product.Quantity++;

                GetListCart();
            }
            GetListCart();

        }
    }
}
