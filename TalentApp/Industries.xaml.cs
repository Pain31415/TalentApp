using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TalentApp
{
    public partial class Industries : UserControl
    {
        public Industries()
        {
            InitializeComponent();
        }

        private void NextStepButton_Click(object sender, RoutedEventArgs e)
        {
            if (IsFieldsValid())
            {
                if (HrToggleButton.IsChecked == true)
                {
                    MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
                    mainWindow.MainFrame.Content = new Window5();
                }
                else if (UserToggleButton.IsChecked == true)
                {
                    MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
                    mainWindow.MainFrame.Content = new Window6();
                }
                else
                {
                    MessageBox.Show("Please select a role (HR or User).");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }

        private bool IsFieldsValid()
        {
            if (FullNameTextBox.Text == "Enter your full name" ||
                LocationTextBox.Text == "Enter your location" ||
                string.IsNullOrWhiteSpace(FullNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(LocationTextBox.Text))
            {
                return false;
            }
            return true;
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "Enter your full name" || textBox.Text == "Enter your location")
            {
                textBox.Text = "";
                textBox.Foreground = new SolidColorBrush(Colors.White);
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (textBox.Name == "FullNameTextBox")
                {
                    textBox.Text = "Enter your full name";
                }
                else if (textBox.Name == "LocationTextBox")
                {
                    textBox.Text = "Enter your location";
                }
                textBox.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void HrToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            UserToggleButton.IsChecked = false;
        }

        private void HrToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
        }

        private void UserToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            HrToggleButton.IsChecked = false;
        }

        private void UserToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
        }
    }
}
