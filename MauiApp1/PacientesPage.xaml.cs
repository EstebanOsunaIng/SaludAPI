using MauiApp1.Models;
using MauiApp1.Services;

namespace MauiApp1
{
    public partial class PacientesPage : ContentPage
    {
        private readonly SupabaseService _supabaseService;

        public PacientesPage()
        {
            InitializeComponent();
            _supabaseService = new SupabaseService();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await CargarPacientes();
        }

        private async Task CargarPacientes()
        {
            try
            {
                var pacientes = await _supabaseService.ObtenerPacientesAsync();
                
                if (pacientes != null && pacientes.Count > 0)
                {
                    PacientesListView.ItemsSource = pacientes;
                    PacientesListView.IsVisible = true;
                    EmptyStateLayout.IsVisible = false;
                }
                else
                {
                    PacientesListView.IsVisible = false;
                    EmptyStateLayout.IsVisible = true;
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"No se pudieron cargar los pacientes: {ex.Message}", "OK");
            }
        }

        private async void OnPacienteSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Paciente paciente)
            {
                // Deseleccionar el item
                ((ListView)sender).SelectedItem = null;

                // Mostrar detalles del paciente
                await DisplayAlert(
                    $"📋 {paciente.NombreCompleto}",
                    $"Edad: {paciente.Edad} años\n" +
                    $"Tipo de Sangre: {paciente.TipoSangre}\n" +
                    $"Teléfono: {paciente.Telefono}\n" +
                    $"Email: {paciente.Email}\n" +
                    $"Dirección: {paciente.Direccion}",
                    "Cerrar"
                );
            }
        }

        private async void OnAgregarPacienteClicked(object sender, EventArgs e)
        {
            // Navegar a la página para agregar nuevo paciente
            await DisplayAlert("Próximamente", "Función de agregar paciente en desarrollo", "OK");
            // Descomentar cuando tengas la página:
            // await Navigation.PushAsync(new NuevoPacientePage());
        }
    }
}