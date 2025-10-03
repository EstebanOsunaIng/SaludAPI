namespace MauiApp1;

public partial class MainPage : ContentPage
{
    private int _count = 0;

    public MainPage()
    {
        InitializeComponent();
        UpdateCounter();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        _count++;
        UpdateCounter();

        // Opcional: Mostrar alerta
        if (_count % 5 == 0)
        {
            DisplayAlert("SaludAPI", $"Has hecho click {_count} veces!", "OK");
        }
    }

    private void UpdateCounter()
    {
        CounterBtn.Text = _count == 0 ? "Click aquí" : $"Clickeado {_count} veces";
        
        // Actualizar el título de la página
        Title = $"SaludAPI - Contador: {_count}";
    }
}