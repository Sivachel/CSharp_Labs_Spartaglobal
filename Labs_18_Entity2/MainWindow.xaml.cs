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

namespace Labs_18_Entity2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NorthwindEntities DBContext = new NorthwindEntities();


        public MainWindow()
        {
            InitializeComponent();
            
            foreach(Customer c1 in DBContext.Customers)
            {
                LBCustomers.Items.Add(c1.ContactName);
            }

            
        }

        //search for customers by city
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            var c2 = from c in DBContext.Customers
                     where c.City == TBCity.Text.ToString()
                     select c;
            LBCity.ItemsSource = c2.ToList<Customer>();
            LBCity.DisplayMemberPath = "ContactName";
        }

        //Customer order displayed in Order listbox when selected
        private void LBCity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Customer c4 = LBCity.SelectedItem as Customer;
            var orderDetails = from od in DBContext.Order_Details
                               join o in DBContext.Orders on od.OrderID equals o.OrderID
                               join c in DBContext.Customers on o.CustomerID equals c.CustomerID
                               where c.CustomerID == c4.CustomerID
                               select od;
            LBorderDetails.ItemsSource = orderDetails.ToList<Order_Detail>();
            LBorderDetails.DisplayMemberPath = "ProductID";

        }

        //Products in the order_details to be displayed in product listbox
        private void LBorderDetails_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Order_Detail c3 = LBorderDetails.SelectedItem as Order_Detail;
            var order = from p in DBContext.Products
                        join od in DBContext.Order_Details on p.ProductID equals od.ProductID
                        where od.ProductID == c3.ProductID
                        select p;
            LBProduct.ItemsSource = order.ToList<Product>();
            LBProduct.DisplayMemberPath = "ProductName";
        }
    }                     
}
