using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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
            // This method can be used to handle additional logic when selection changes.
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
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow.MainFrame.Content = new Window7();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow.MainFrame.Content = new Industries();
        }
    }
}
