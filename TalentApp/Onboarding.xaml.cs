using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;

namespace TalentApp
{
    public partial class Onboarding : UserControl
    {
        public Onboarding()
        {
            InitializeComponent();
        }

        private void UploadButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Documents (*.pdf;*.doc;*.rtf;*.txt)|*.pdf;*.doc;*.rtf;*.txt";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                MessageBox.Show("File Uploaded: " + filePath);
            }
        }

        private void NextStepButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Proceed to the next step");
        }
    }
}
