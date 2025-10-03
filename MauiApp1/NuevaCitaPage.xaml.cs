using MauiApp1.Models;
using MauiApp1.Services;

namespace MauiApp1
{
    public partial class NuevaCitaPage : ContentPage
    {
        private readonly SupabaseService _supabaseService;

        public NuevaCitaPage()
        {
            InitializeComponent();
            _supabaseService = new SupabaseService();
        }

        private async void OnGuardarClicked(object sender, EventArgs e)
        {
            var cita = new Cita
            {
                Id = Guid.NewGuid(),
                Paciente = PacienteEntry.Text,
                Doctor = DoctorEntry.Text,
                Fecha = FechaPicker.Date,
                Hora = HoraPicker.Time,
                Motivo = MotivoEntry.Text
            };

            await _supabaseService.InsertarCitaAsync(cita);
            await DisplayAlert("Éxito", "Cita guardada correctamente", "OK");
            await Navigation.PopAsync(); // volver atrás
        }
    }
}
