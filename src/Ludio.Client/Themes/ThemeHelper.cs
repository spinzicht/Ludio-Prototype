using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Ludio.Themes
{
    public class ThemeResourceDictionary : ResourceDictionary { }
    public enum Theme { Dark, Light }

    public class ThemeHelper
    {
        public static Theme Theme { get; set; }

        public static void ChangeTheme(Theme newTheme)
        {
            Theme = newTheme;
            switch (Theme)
            {
                case Theme.Dark:
                    ApplyTheme("Themes/DarkTheme.xaml");
                    break;
                case Theme.Light:
                    ApplyTheme("Themes/LightTheme.xaml");
                    break;
            };
        }

        public static void ToggleTheme()
        {
            ChangeTheme(Theme == Theme.Dark ? Theme.Light : Theme.Dark);
        }

        public static void ApplyTheme(string src)
        {
            // remove the existing theme dictionaries
            var list = Application.Current.Resources.MergedDictionaries.OfType<ThemeResourceDictionary>().ToList();

            foreach (ThemeResourceDictionary thDictionary in list)
            {
                Application.Current.Resources.MergedDictionaries.Remove(thDictionary);
            }

            //add new theme dictionaries
            ThemeResourceDictionary themeDictionary = new ThemeResourceDictionary() { Source = new Uri(src, UriKind.Relative) };
            if (themeDictionary.MergedDictionaries.Count > 0)
            {
                foreach (ThemeResourceDictionary mergeDict in themeDictionary.MergedDictionaries)
                {
                    Application.Current.Resources.MergedDictionaries.Add(mergeDict);
                }
            }
            else
            {
                Application.Current.Resources.MergedDictionaries.Add(themeDictionary);
            }
        }
    }
}
