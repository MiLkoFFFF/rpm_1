using System.Collections.Generic;
using System.Windows;
using SportRent.Models;

namespace SportRent.Views
{
    public partial class CatalogWindow : Window
    {
        public static List<InventoryItem> InventoryList = new List<InventoryItem>();

        public CatalogWindow()
        {
            InitializeComponent();
            LoadInventory();
        }

        private void LoadInventory()
        {
            InventoryListBox.Items.Clear();
            foreach (var item in InventoryList)
            {
                InventoryListBox.Items.Add(item);
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
