using System.Windows;
using System.Windows.Controls;

namespace TalentApp
{
    public partial class Window8 : UserControl
    {
        public Window8()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Next button clicked");
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            
            Window6 window6 = new Window6();

            
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                parentWindow.Content = window6;
            }
        }

        private void SalaryComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SalaryComboBox.SelectedItem != null)
            {
                SearchTextBox.Text = SalaryComboBox.Text;
            }
        }

        private void SalaryComboBox_GotFocus(object sender, RoutedEventArgs e)
        {
            SearchTextBox.Text = "";
        }

        private void SalaryComboBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                SearchTextBox.Text = "Choose your salary bundling";
            }
        }
    }
}
