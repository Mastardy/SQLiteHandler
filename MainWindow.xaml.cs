using System.Windows;
using System.Windows.Controls;

using SQLiteHandler.Pages;
using SQLiteHandler.Model;

namespace SQLiteHandler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Model.Model.Instance.OnDatabaseComplete += LoadDatabase;
        }

        private void Database_New(object sender, RoutedEventArgs routedEventArgs)
        {
            MainFrame.Content = new NewDatabasePage();
        }

        private void LoadDatabase(string name)
        {
            MainFrame.Content = null;
            // TODO - Give Real Functionality
            DatabaseStackPanel.Children.Add(new Button { Style = (Style)Resources["DatabaseButton"], Content = name });
        }
    }
}