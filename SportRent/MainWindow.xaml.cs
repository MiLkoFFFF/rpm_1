using System.Windows;
using SportRent.Views;

namespace SportRent
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenCatalog_Click(object sender, RoutedEventArgs e)
        {
            CatalogWindow catalogWindow = new CatalogWindow();
            catalogWindow.Show();
            this.Close();
        }

        private void OpenAddInventory_Click(object sender, RoutedEventArgs e)
        {
            AddInventoryWindow addInventoryWindow = new AddInventoryWindow();
            addInventoryWindow.Show();
            this.Close();
        }

        private void OpenBooking_Click(object sender, RoutedEventArgs e)
        {
            BookingWindow bookingWindow = new BookingWindow();
            bookingWindow.Show();
            this.Close();
        }

    }
}
