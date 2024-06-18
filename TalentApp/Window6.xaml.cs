using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TalentApp
{
    public partial class Window6 : UserControl
    {
        public Window6()
        {
            InitializeComponent();
        }

        private void IndustryComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Обробка вибору в ComboBox
        }

        private void IndustryComboBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (SearchTextBox.Text == "Search industry...")
            {
                SearchTextBox.Text = "";
                SearchTextBox.Foreground = new SolidColorBrush(Colors.White);
            }
        }

        private void IndustryComboBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                SearchTextBox.Text = "Search industry...";
                SearchTextBox.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void NextStepButton_Click(object sender, RoutedEventArgs e)
        {
            // Обробка натискання кнопки "Next step"
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow.MainFrame.Content = new Industries();
        }
    }
}
