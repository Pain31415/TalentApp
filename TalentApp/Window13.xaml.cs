using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace TalentApp
{
    public partial class Window13 : UserControl
    {
        public Window13()
        {
            InitializeComponent();
        }

        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            await Task.Delay(5000); // 5 seconds delay
            LoadingPanel.Visibility = Visibility.Collapsed;
            SuccessPanel.Visibility = Visibility.Visible;

            await Task.Delay(2000); // 2 seconds delay after showing success
            NavigateToHome();
        }

        private void NavigateToHome()
        {
            var parentWindow = Window.GetWindow(this);
            parentWindow.Content = new Home();
        }
    }
}
