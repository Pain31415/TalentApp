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
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            if (mainWindow != null)
            {
                Frame mainFrame = mainWindow.MainFrame;
                if (mainFrame != null)
                {
                    mainFrame.Navigate(new Window13());
                }
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            if (mainWindow != null)
            {
                Frame mainFrame = mainWindow.MainFrame;
                if (mainFrame != null)
                {
                    mainFrame.Navigate(new Window7());
                }
            }
        }
    }
}
