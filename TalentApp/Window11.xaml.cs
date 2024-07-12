using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TalentApp
{
    public partial class Window11 : UserControl
    {
        public Window11()
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
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.MainFrame.Content = new Window13();
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
