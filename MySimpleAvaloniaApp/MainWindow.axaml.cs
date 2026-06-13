using Avalonia.Controls;
using Avalonia.Interactivity;

namespace MySimpleAvaloniaApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void GreetButton_Click(object? sender, RoutedEventArgs e)
    {
        var name = NameTextBox.Text;
        
        if (string.IsNullOrWhiteSpace(name))
        {
            GreetingLabel.Text = "Hello, Guest!";
        }
        else
        {
            GreetingLabel.Text = $"Hello, {name}!";
        }
    }

    private void CalculateButton_Click(object? sender, RoutedEventArgs e)
    {
        var input1 = Number1TextBox.Text;
        var input2 = Number2TextBox.Text;

        if (int.TryParse(input1, out int num1) && int.TryParse(input2, out int num2))
        {
            int sum = num1 + num2;
            ResultLabel.Text = $"Result: {num1} + {num2} = {sum}";
        }
        else
        {
            ResultLabel.Text = "Please enter valid numbers!";
        }
    }
}