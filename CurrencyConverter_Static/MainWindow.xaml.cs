using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Text.RegularExpressions;

namespace CurrencyConverter_Static
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Wpf.Ui.Controls.UiWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            InitializeUi();
        }

        private void InitializeUi()
        {
            Loaded += async (sender, args) =>
            {
                // After loading the main application window,
                // we register the Watcher class, which automatically
                // changes the theme and accent of the application.
                Wpf.Ui.Appearance.Watcher.Watch(this, Wpf.Ui.Appearance.BackgroundType.Mica, true, true);
                Wpf.Ui.Appearance.Accent.Apply(
                    Color.FromRgb(0, 160, 0),// Base system accent
                    Wpf.Ui.Appearance.ThemeType.Dark, // Theme type
                    true);                              // Whether GlassColor is used

                //Go to Home
                RootNavigation.SelectedPageIndex = 0;
            };
        }


        private void RootNavigation_OnNavigated(Wpf.Ui.Controls.Interfaces.INavigation sender, Wpf.Ui.Common.RoutedNavigationEventArgs e)
        {

        }
    }
}
