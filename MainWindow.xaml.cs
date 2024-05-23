using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CoffeeShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        string[] items = { "Coffee", "Orange Juice", "Iced Tea", "Cupcake", "Chicken and Mayo Sandwich", "Cookies", "Brownies" };
        double[] priceOfItem = { 20.00, 15.00, 18.00, 10.00, 25.00, 12.00, 15.00 };

        string display;
        string item;
        double itemPrice;
        double price = 0;
        int quantity;
        double total;



        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            item = ((ComboBoxItem)cmbItem.SelectedItem).Content.ToString();
            itemPrice = priceOfItem[cmbItem.SelectedIndex]; 
            quantity = Convert.ToInt32(txtQuantity.Text);
            price = itemPrice * quantity;
            total += price;
            display +=  item + "  R" + itemPrice + "  " + quantity + "   R" + price + "\n";
            MessageBox.Show("Item Added to Order");
        }

        private void btnNewOrder_Click(object sender, RoutedEventArgs e)
        {

            lstDisplay.Items.Clear();
            total = 0;
            price = 0;
        }

        private void btnTotal_Click(object sender, RoutedEventArgs e)
        {
            lstDisplay.Items.Add("ORDER");
            lstDisplay.Items.Add(display);
            lstDisplay.Items.Add("TOTAL");
            lstDisplay.Items.Add("R" + total);
        }
    }
}