using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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
            bool isPhoneNumberValid = IsPhoneNumberValid(PhoneNumberTextBox.Text);
            bool isVerificationCodeValid = IsVerificationCodeValid(VerificationCodeTextBox.Text);

            NextButton.IsEnabled = isPhoneNumberValid && isVerificationCodeValid;
        }

        private bool IsPhoneNumberValid(string phoneNumber)
        {
            return !string.IsNullOrWhiteSpace(phoneNumber) && IsTextAllowed(phoneNumber);
        }

        private bool IsVerificationCodeValid(string verificationCode)
        {
            return verificationCode.Length == 4 && IsTextAllowed(verificationCode);
        }

        private bool IsTextAllowed(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void PhoneNumberTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateNextButtonState();
        }

        private void VerificationCodeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (VerificationCodeTextBox.Text.Length > 4)
            {
                VerificationCodeTextBox.Text = VerificationCodeTextBox.Text.Substring(0, 4);
                VerificationCodeTextBox.Select(VerificationCodeTextBox.Text.Length, 0);
            }
            UpdateNextButtonState();
        }

        private void VerificationCodeTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text) || VerificationCodeTextBox.Text.Length >= 4;
        }

        private void VerificationCodeTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (VerificationCodeTextBox.Text.Length != 4)
            {
                VerificationCodeErrorTextBlock.Text = "Please enter exactly 4 digits.";
            }
            else
            {
                VerificationCodeErrorTextBlock.Text = "";
            }
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
                    mainFrame.Navigate(new Window10());
                }
            }
        }
    }
}
