using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TalentApp
{
    public partial class Window9 : UserControl
    {
        public Window9()
        {
            InitializeComponent();
            UpdateNextButtonState();
        }

        private void IndustryComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateNextButtonState();
        }

        private void UpdateNextButtonState()
        {
            NextButton.IsEnabled = IndustryComboBox.SelectedItem != null;
        }

        private void IndustryComboBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (SearchTextBox.Text == "Business")
            {
                SearchTextBox.Text = "";
                SearchTextBox.Foreground = new SolidColorBrush(Colors.White);
            }
        }

        private void IndustryComboBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                SearchTextBox.Text = "Business";
                SearchTextBox.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.MainFrame.Content = new Window11();
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.MainFrame.Content = new Window7();
            }
        }
    }
}
