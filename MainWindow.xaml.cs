using System.Windows;
using Antivirus_and_security.View;

namespace Antivirus_and_security
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainContent.Content = new Dashboard();
        }

        private void DashboardBtn_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new Dashboard();
        }

        private void ProtectionBtn_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new Protection();
        }

        private void PrivacyBtn_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new Privacy();
        }

        private void PerformanceBtn_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new Performance();
        }

        private void SettingsBtn_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new Settings();
        }

        // =====================================================
        // LIGHT THEME
        // =====================================================

        private void LightTheme_Click(object sender, RoutedEventArgs e)
        {
            ((App)Application.Current).ChangeTheme("Light");
        }

        // =====================================================
        // DARK THEME
        // =====================================================

        private void DarkTheme_Click(object sender, RoutedEventArgs e)
        {
            ((App)Application.Current).ChangeTheme("Dark");
        }
    }
}