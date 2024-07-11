using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TalentApp
{
    public partial class Window7 : UserControl
    {
        public Window7()
        {
            InitializeComponent();
        }

        private void SalaryComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SalaryComboBox.SelectedIndex != -1)
            {
                NextButton.IsEnabled = true;
            }
            else
            {
                NextButton.IsEnabled = false;
            }
        }

        private void SalaryComboBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (SearchTextBox.Text == "Choose your salary bundling")
            {
                SearchTextBox.Text = "";
                SearchTextBox.Foreground = new SolidColorBrush(Colors.White);
            }
        }

        private void SalaryComboBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                SearchTextBox.Text = "Choose your salary bundling";
                SearchTextBox.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.MainFrame.Content = new Window9();
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.MainFrame.Content = new Window5();
            }
        }
    }
}
