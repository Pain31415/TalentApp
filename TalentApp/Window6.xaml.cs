using System.Windows;
using System.Windows.Controls;

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
            if (IndustryComboBox.SelectedIndex != -1)
            {
                NextStepButton.IsEnabled = true;
            }
            else
            {
                NextStepButton.IsEnabled = false;
            }
        }

        private void NextStepButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow.MainFrame.Content = new Window8();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow.MainFrame.Content = new Industries();
        }
    }
}
