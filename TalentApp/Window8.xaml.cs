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
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.MainFrame.Content = new Window10();
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.MainFrame.Content = new Window6();
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
