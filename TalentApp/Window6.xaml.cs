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
            // Handle ComboBox selection change if needed
        }

        private void NextStepButton_Click(object sender, RoutedEventArgs e)
        {
            // Handle "Next step" button click
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow.MainFrame.Content = new Industries();
        }
    }
}
