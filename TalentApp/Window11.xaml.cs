using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Data;

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
            NextButton.IsEnabled = !string.IsNullOrWhiteSpace(PhoneNumberTextBox.Text) &&
                                   VerificationCodeTextBox.Text.Length == 4;
        }

        private void PhoneNumberTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateNextButtonState();
        }

        private void VerificationCodeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateNextButtonState();
        }

        private void VerificationCodeTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsDigitsOnly(e.Text) || VerificationCodeTextBox.Text.Length >= 4;
        }

        private void VerificationCodeTextBox_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(DataFormats.Text))
            {
                string text = (string)e.DataObject.GetData(DataFormats.Text);
                if (!IsDigitsOnly(text) || VerificationCodeTextBox.Text.Length + text.Length > 4)
                {
                    e.CancelCommand();
                }
            }
            else
            {
                e.CancelCommand();
            }
        }

        private void VerificationCodeTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (VerificationCodeTextBox.Text.Length != 4)
            {
                VerificationCodeErrorTextBlock.Text = "Please enter exactly 4 digits.";
                VerificationCodeTextBox.Focus();
            }
            else
            {
                VerificationCodeErrorTextBlock.Text = "";
            }
        }

        private bool IsDigitsOnly(string text)
        {
            return Regex.IsMatch(text, @"^\d+$");
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (IsPhoneNumberValid() && IsVerificationCodeValid())
            {
                MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
                if (mainWindow != null)
                {
                    Frame? mainFrame = mainWindow.MainFrame;
                    if (mainFrame != null)
                    {
                        mainFrame.Navigate(new Window13());
                    }
                }
            }
        }

        private bool IsPhoneNumberValid()
        {
            return IsDigitsOnly(PhoneNumberTextBox.Text);
        }

        private bool IsVerificationCodeValid()
        {
            return VerificationCodeTextBox.Text.Length == 4;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            if (mainWindow != null)
            {
                Frame? mainFrame = mainWindow.MainFrame;
                if (mainFrame != null)
                {
                    mainFrame.Navigate(new Window9());
                }
            }
        }
    }
}
