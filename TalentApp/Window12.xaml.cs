using System.Windows;
using System.Windows.Controls;

namespace TalentApp
{
    public partial class Window12 : UserControl
    {
        public Window12()
        {
            InitializeComponent();
            UpdateNextButtonState();
        }

        private void UpdateNextButtonState()
        {
            NextButton.IsEnabled = !string.IsNullOrWhiteSpace(PhoneNumberTextBox.Text) && !string.IsNullOrWhiteSpace(VerificationCodeTextBox.Text);
        }

        private void PhoneNumberTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateNextButtonState();
        }

        private void VerificationCodeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateNextButtonState();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Window13
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.MainFrame.Content = new Window13();
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate back to Window11
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.MainFrame.Content = new Window11();
            }
        }
    }
}