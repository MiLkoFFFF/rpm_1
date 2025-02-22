using System;
using System.Windows;
using SportRent.Models;
using System.Collections.Generic;

namespace SportRent.Views
{
    public partial class BookingWindow : Window
    {
        public static List<Booking> Bookings = new List<Booking>();

        public BookingWindow()
        {
            InitializeComponent();
            LoadInventory();
        }

        private void LoadInventory()
        {
            InventoryComboBox.Items.Clear();
            foreach (var item in CatalogWindow.InventoryList)
            {
                InventoryComboBox.Items.Add(item);
            }
        }

        private void BookItem_Click(object sender, RoutedEventArgs e)
        {
            string hoursText = HoursBox.Text;

            if (int.TryParse(hoursText, out int hours))
            {
                ResultLabel.Content = $"Вы выбрали {hours} часов для бронирования.";
            }
            else
            {
                ResultLabel.Content = "Введите корректное количество часов.";
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void HoursBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            e.Handled = !char.IsDigit(e.Text, 0);
        }
    }
}
