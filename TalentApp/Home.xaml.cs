using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

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
    }
}
