using Domain.Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using TalentApp.Domain;

namespace TalentApp
{
    public partial class Home : Window
    {
        private bool isSidebarExpanded = false;

        public Home()
        {
            InitializeComponent();
            
        }

        private void ToggleSidebarButton_Click(object sender, RoutedEventArgs e)
        {
            if (isSidebarExpanded)
            {
                CollapseSidebar();
            }
            else
            {
                ExpandSidebar();
            }

            isSidebarExpanded = !isSidebarExpanded;
        }

        private void ExpandSidebar()
        {
            Storyboard expandStoryboard = (Storyboard)FindResource("ExpandSidebar");
            expandStoryboard.Begin();
        }

        private void CollapseSidebar()
        {
            Storyboard collapseStoryboard = (Storyboard)FindResource("CollapseSidebar");
            collapseStoryboard.Begin();
        }

        private void NavigationButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string tag = button.Tag.ToString();

            UserControl contentControl = null;
            Window window = null;

            switch (tag)
            {
                case "Home":
                    contentControl = new HomeControl();
                    break;
                case "Documents":
                    contentControl = new DocumentsControl();
                    break;
                case "Mail":
                    contentControl = new MailControl();
                    break;
                case "User":
                    contentControl = new UserControlControl();
                    break;
                case "HR":
                    contentControl = new HRControl();
                    break;
                case "Settings":
                    window = new SettingsWindow();
                    break;
                default:
                    return;
            }

            if (window != null)
            {
                window.Show();
                this.Close();
            }
            else
            {
                MainContent.Content = contentControl;
            }
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AppDataGrid.ItemsSource = await UseCase.GetUsers();
        }
    }

    // Зразкові класи для заміни відсутніх типів UserControl
    public class HomeControl : UserControl
    {
      
        public HomeControl()
        {
            DataGrid dataGrid = new DataGrid();
            dataGrid.ItemsSource = UseCase.GetUsers().Result;
            Content =dataGrid;
        }
    }

    public class DocumentsControl : UserControl
    {
        public DocumentsControl()
        {
            Content = new TextBlock { Text = "Documents Content", Foreground = System.Windows.Media.Brushes.White };
        }
    }

    public class MailControl : UserControl
    {
        public MailControl()
        {
            Content = new TextBlock { Text = "Mail Content", Foreground = System.Windows.Media.Brushes.White };
        }
    }

    public class UserControlControl : UserControl
    {
        public UserControlControl()
        {
            Content = new TextBlock { Text = "User Content", Foreground = System.Windows.Media.Brushes.White };
        }
    }

    public class HRControl : UserControl
    {
        public HRControl()
        {
            Content = new TextBlock { Text = "HR Content", Foreground = System.Windows.Media.Brushes.White };
        }
    }

    public class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            Title = "Settings Window";
            Width = 800;
            Height = 600;
        }
    }
}