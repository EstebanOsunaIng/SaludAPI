using MauiApp1.Models;
using MauiApp1.Services;

namespace MauiApp1
{
    public partial class CitasPage : ContentPage
    {
        private readonly SupabaseService _supabaseService;

        public CitasPage()
        {
            InitializeComponent();
            _supabaseService = new SupabaseService();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var citas = await _supabaseService.ObtenerCitasAsync();
            CitasListView.ItemsSource = citas;
        }
    }
}
