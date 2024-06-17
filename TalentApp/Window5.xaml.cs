using System.Windows;
using System.Windows.Controls;

namespace TalentApp
{
    public partial class Window5 : UserControl
    {
        public Window5()
        {
            InitializeComponent();
        }

        private void IndustryComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Логіка для обробки вибору в ComboBox
            if (SearchTextBox != null && IndustryComboBox.SelectedItem != null)
            {
                SearchTextBox.Text = ((ComboBoxItem)IndustryComboBox.SelectedItem).Content.ToString();
            }
        }

        private void IndustryComboBox_GotFocus(object sender, RoutedEventArgs e)
        {
            SearchTextBox.IsReadOnly = false;
            SearchTextBox.Text = string.Empty;
        }

        private void IndustryComboBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                SearchTextBox.IsReadOnly = true;
                SearchTextBox.Text = "Search industry...";
            }
        }
    }
}
