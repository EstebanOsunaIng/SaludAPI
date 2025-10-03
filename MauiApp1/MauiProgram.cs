using Supabase;

namespace MauiApp1;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        // 🔹 Inicializar el cliente Supabase
        var supabase = new Client(
            "https://urafaskxxxpxyhqhhsvr.supabase.co",   // 👉 cambia esto
            "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InVyYWZhc2t4eHhweHlocWhoc3ZyIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NTk1MDkzMTgsImV4cCI6MjA3NTA4NTMxOH0.4_GEtl8HvzID1Igtli10NKtpxmpeXjkWImivNYA9XCM",                         // 👉 cambia esto
            new SupabaseOptions { AutoConnectRealtime = true }
        );

        // 🔹 Registrar el cliente como Singleton
        builder.Services.AddSingleton(supabase);

        return builder.Build();
    }
}
