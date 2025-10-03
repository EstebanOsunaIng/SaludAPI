using SaludAPI.Models;
using SaludAPI.Services;

namespace SaludAPI;

public partial class NuevaCitaPage : ContentPage
{
    private SupabaseService _service;

    public NuevaCitaPage()
    {
        InitializeComponent();
        _service = new SupabaseService();
    }

    private async void OnGuardarClicked(object sender, EventArgs e)
    {
        var cita = new Cita
        {
            Paciente = PacienteEntry.Text,
            Fecha = FechaPicker.Date,
            Motivo = MotivoEntry.Text
        };

        await _service.AddCitaAsync(cita);
        await DisplayAlert("Éxito", "Cita registrada", "OK");
        await Navigation.PopAsync();
    }
}
