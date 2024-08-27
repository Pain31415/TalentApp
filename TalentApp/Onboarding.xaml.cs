using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;

namespace TalentApp
{
    public partial class Onboarding : UserControl
    {
        // Статичний шлях до завантаженого файлу
        public static string UploadedFilePath { get; private set; }

        public Onboarding()
        {
            InitializeComponent();
        }

        private void UploadButton_Click(object sender, RoutedEventArgs e)
        {
            // Створюємо діалогове вікно для вибору файлу
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Documents (*.pdf;*.doc;*.rtf;*.txt)|*.pdf;*.doc;*.rtf;*.txt",
                Multiselect = false
            };

            // Якщо файл вибрано, зберігаємо шлях і відображаємо повідомлення
            if (openFileDialog.ShowDialog() == true)
            {
                UploadedFilePath = openFileDialog.FileName;
                MessageBox.Show("File Uploaded: " + UploadedFilePath);
            }
        }

        private void NextStepButton_Click(object sender, RoutedEventArgs e)
        {
            // Переходимо до наступного етапу (наприклад, до іншого UserControl)
            var mainWindow = (MainWindow)Window.GetWindow(this);
            mainWindow.MainFrame.Content = new Industries();
        }
    }
}
