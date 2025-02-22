using System;
using System.Windows;
using SportRent.Models;

namespace SportRent.Views
{
    public partial class AddInventoryWindow : Window
    {
        public AddInventoryWindow()
        {
            InitializeComponent();
        }

        private void AddInventory_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var newItem = new InventoryItem
                {
                    Type = TypeBox.Text,
                    Name = NameBox.Text,
                    Description = DescriptionBox.Text,
                    Size = SizeBox.Text,
                    Price = Convert.ToDecimal(PriceBox.Text),
                    IsAvailable = AvailableCheckBox.IsChecked ?? false,
                    HasDiscount = DiscountCheckBox.IsChecked ?? false
                };

                MessageBox.Show($"Инвентарь \"{newItem.Name}\" добавлен!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);

                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка! Некорректный формат данных в поле 'Цена'.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
