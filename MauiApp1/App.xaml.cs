using Microsoft.Maui.Controls;

namespace MauiApp1;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        var window = new Window();
        window.Page = new AppShell();
        window.Title = "SaludAPI";
        return window;
    }
}