namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnCitasClicked(object sender, EventArgs e)
    {
        // Navegar a la página de citas
        await Navigation.PushAsync(new CitasPage());
    }

    private async void OnPacientesClicked(object sender, EventArgs e)
    {
        // Navegar a la página de pacientes (cuando la tengas)
        await DisplayAlert("Pacientes", "Función en desarrollo", "OK");
        // Descomentar cuando tengas la página:
        // await Navigation.PushAsync(new PacientesPage());
    }

    private async void OnHistorialesClicked(object sender, EventArgs e)
    {
        // Navegar a la página de historiales (cuando la tengas)
        await DisplayAlert("Historiales", "Función en desarrollo", "OK");
        // Descomentar cuando tengas la página:
        // await Navigation.PushAsync(new HistorialesPage());
    }

    private async void OnEstadisticasClicked(object sender, EventArgs e)
    {
        // Navegar a estadísticas (cuando la tengas)
        await DisplayAlert("Estadísticas", "Función en desarrollo", "OK");
        // Descomentar cuando tengas la página:
        // await Navigation.PushAsync(new EstadisticasPage());
    }
}