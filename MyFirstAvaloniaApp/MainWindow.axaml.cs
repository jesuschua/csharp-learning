using Avalonia.Controls;
using Avalonia.Interactivity;

namespace MyFirstAvaloniaApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnGreetClicked(object? sender, RoutedEventArgs e)
    {
        string name = NameEntry.Text ?? "";
        
        if (string.IsNullOrWhiteSpace(name))
        {
            name = "Guest";
        }
        
        ResultLabel.Text = $"Hello, {name}!";
    }
}

