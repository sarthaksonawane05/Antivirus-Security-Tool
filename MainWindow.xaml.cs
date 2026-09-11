using System.Windows;
using morden_dark_dashboard.View;

namespace morden_dark_dashboard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainContent.Content = new Dahboard();
        }

        // ================= NAVIGATION =================

        private void DashboardBtn_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new Dahboard();
        }

        private void ScanBtn_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new scan();
        }

        private void RealTimeBtn_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new Real_time_protection();
        }

        private void QuarantineBtn_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new Quarantine();
        }

        private void ThreatBtn_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new Threat_History();
        }

        private void FirewallBtn_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new Firewall();
        }

        private void PrivacyBtn_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new Privacy_Protection();
        }

        private void PerformanceBtn_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new Performance();
        }

        private void SettingsBtn_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new Settings();
        }

        // ================= THEME SWITCH =================

        private void DarkTheme_Click(object sender, RoutedEventArgs e)
        {
            ((App)Application.Current).ChangeTheme("Dark");
        }

        private void LightTheme_Click(object sender, RoutedEventArgs e)
        {
            ((App)Application.Current).ChangeTheme("Light");
        }
    }
}