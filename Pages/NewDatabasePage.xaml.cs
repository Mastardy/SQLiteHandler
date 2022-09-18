using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

using SQLiteHandler.Model;
namespace SQLiteHandler.Pages;

public partial class NewDatabasePage : Page
{
    public NewDatabasePage()
    {
        InitializeComponent();
    }

    private void NewDatabase_OnKeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key != Key.Return) return;
        
        NewDatabaseButton.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
    }

    private void NewDatabase_Create(object sender, RoutedEventArgs e)
    {
        if (Model.Model.Instance.NewDatabase(NewDatabaseTextBox.Text)) return;
        NewDatabaseTextBox.Text = string.Empty;
    }
}