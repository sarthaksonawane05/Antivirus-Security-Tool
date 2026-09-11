using System;
using System.Windows;

namespace Antivirus_and_security
{
    public partial class App : Application
    {
        public void ChangeTheme(string themeName)
        {
            ResourceDictionary theme = new ResourceDictionary();

            switch (themeName)
            {
                case "Light":
                    theme.Source = new Uri("Themes/Light_Theme.xaml", UriKind.Relative);
                    break;

                default:
                    theme.Source = new Uri("Themes/Dark_Themes.xaml", UriKind.Relative);
                    break;
            }

            Resources.MergedDictionaries.Clear();
            Resources.MergedDictionaries.Add(theme);
        }
    }
}