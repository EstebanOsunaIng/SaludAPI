namespace SaludAPI;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Registrar rutas para navegación
        Routing.RegisterRoute(nameof(NuevaCitaPage), typeof(NuevaCitaPage));
        Routing.RegisterRoute(nameof(CitasPage), typeof(CitasPage));
    }
}
