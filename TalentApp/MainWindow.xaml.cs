using Domain.Models;
using Server;
using Supabase;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TalentApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tbEmail.Text = "Unknown user";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if(SupabaseSingleton.Instance.Auth.CurrentUser != null)
            {
                tbEmail.Text = SupabaseQuerys.GetCurrentUserEmail();
            }
            else
            {
                tbEmail.Text = "No user";
            }
          
        }

        private async void btn_Click(object sender, RoutedEventArgs e)
        {
            await SupabaseQuerys.SignUpUser("vlad.lysenko1999@gmail.com", "111111");
            tbEmail.Text = SupabaseQuerys.GetCurrentUserEmail();
        }

        private async void btn_Click_SignIn(object sender, RoutedEventArgs e)
        {
            //await SupabaseSingleton.Instance.Auth.SignIn("vlad.lysenko1999@gmail.com", "111111");
            await SupabaseQuerys.SignInWithGoogle();
            tbEmail.Text = SupabaseQuerys.GetCurrentUserEmail();
        }

        private async void btn_Click_Get(object sender, RoutedEventArgs e)
        {
            if (SupabaseSingleton.Instance.Auth.CurrentUser != null)
            {
                var users = await SupabaseQuerys.GetUsers();
                dgMain.ItemsSource = users;
                UpdateLayout();
            }
            else
            {
                tbEmail.Text = "No user. No action.";
            }
        }
    }
}