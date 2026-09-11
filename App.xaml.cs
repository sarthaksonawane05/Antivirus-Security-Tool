using System;
using System.Linq;
using System.Windows;

namespace morden_dark_dashboard
{
    public partial class App : Application
    {
        public void ChangeTheme(string theme)
        {
            var dict = new ResourceDictionary
            {
                Source = new Uri($"Theme/{theme}.xaml", UriKind.Relative)
            };

            var oldThemes = Resources.MergedDictionaries
                .Where(x =>
                    x.Source != null &&
                    (x.Source.ToString().Contains("Dark.xaml") ||
                     x.Source.ToString().Contains("Light.xaml")))
                .ToList();

            foreach (var item in oldThemes)
                Resources.MergedDictionaries.Remove(item);

            Resources.MergedDictionaries.Add(dict);
        }
    }
}