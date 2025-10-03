using SaludAPI.Models;
using SaludAPI.Services;

namespace SaludAPI;

public partial class CitasPage : ContentPage
{
    private SupabaseService _service;

    public CitasPage()
    {
        InitializeComponent();
        _service = new SupabaseService();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        var citas = await _service.GetCitasAsync();
        CitasCollection.ItemsSource = citas;
    }

    private async void OnNuevaCitaClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NuevaCitaPage());
    }
}
