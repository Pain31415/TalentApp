using Domain.Models;
using Server;
using Supabase;
using System.Windows;
using System.Windows.Controls;

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
