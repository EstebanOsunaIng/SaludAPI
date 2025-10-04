namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnCitasClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//CitasPage");
    }

    private async void OnPacientesClicked(object sender, EventArgs e)
    {
        // ✅ Navegar a la página de pacientes
        await Navigation.PushAsync(new PacientesPage());
    }

    private async void OnHistorialesClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Historiales", "Función en desarrollo", "OK");
    }

    private async void OnEstadisticasClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Estadísticas", "Función en desarrollo", "OK");
    }
}