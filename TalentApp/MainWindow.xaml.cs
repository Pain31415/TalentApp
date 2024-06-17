using System.Windows;

namespace TalentApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new Onboarding();
        }
    }
}
