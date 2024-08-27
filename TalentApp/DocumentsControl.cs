using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TalentApp
{
    public class DocumentsControl : UserControl
    {
        public DocumentsControl()
        {
            var stackPanel = new StackPanel();
            stackPanel.Background = Brushes.Black;

            // Перевірка на наявність завантаженого файлу
            if (!string.IsNullOrEmpty(Onboarding.UploadedFilePath))
            {
                string filePath = Onboarding.UploadedFilePath;

                // Перевірка типу файлу і відображення відповідного вмісту
                if (File.Exists(filePath))
                {
                    string fileContent = File.ReadAllText(filePath);
                    stackPanel.Children.Add(new TextBlock { Text = fileContent, Foreground = Brushes.White, TextWrapping = TextWrapping.Wrap });
                }
                else
                {
                    stackPanel.Children.Add(new TextBlock { Text = "File does not exist.", Foreground = Brushes.Red });
                }
            }
            else
            {
                stackPanel.Children.Add(new TextBlock { Text = "No file uploaded", Foreground = Brushes.Gray });
            }

            Content = stackPanel;
        }
    }
}
