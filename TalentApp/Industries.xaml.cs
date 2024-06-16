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
            MessageBox.Show("Proceed to the next step");
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
    }
}
