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

namespace Labs_17_Entitywpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NorthwindEntities DBcontext = new NorthwindEntities();

        public MainWindow()
        {
            InitializeComponent();
            foreach(Customer c in DBcontext.Customers)
            {
                ListBox01.Items.Add(string.Format("{0} lives in {1}",c.ContactName,c.City));
            }

         
        }
        
        private void Button01_Click(object sender, RoutedEventArgs e)
        {
            var customers2 = from c in DBcontext.Customers
                             where c.City == Textbox01.Text.ToString()
                             select c;

            ListBox02.ItemsSource = customers2.ToList<Customer>();
            ListBox02.DisplayMemberPath = "ContactName";
        }

        private void ListBox02_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Customer customers3 = ListBox02.SelectedItem as Customer;
            ListBox03.Items.Clear();
            //ListBox03.Items.Add(String.Format("{0} lives in {1}", customers3.ContactName, customers3.Country));
            ListBox03.Items.Add(String.Format(" Name: {0}\n Job: {1}\n Address: {2}\n City: {3} ", customers3.ContactName, customers3.ContactTitle, customers3.Address, customers3.City));
        }

        private void Button02_Click(object sender, RoutedEventArgs e)
        {
            Customer customers3 = ListBox02.SelectedItem as Customer;
            customers3.City = Textbox02.Text;
            DBcontext.SaveChanges();
        }

        private void Button03_Click(object sender, RoutedEventArgs e)
        {
            int customerID = DBcontext.Customers.Count<Customer>();
            customerID++;
            DBcontext.Customers.Add(new Customer
            {
                CustomerID = customerID.ToString(),
                CompanyName = "NULL",
                ContactName = "NULL",
                ContactTitle = "NULL",
                Address = "NULL",
                City = Textbox01.Text,
                Region = "NULL",
                PostalCode = "NULL",
                Country = "NULL",
                Phone = "NULL",
                Fax = "NULL"
            });
            DBcontext.SaveChanges();
        }
    }
}
