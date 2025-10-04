using Supabase;
using Supabase.Postgrest;
using MauiApp1.Models;

namespace MauiApp1.Services
{
    public class SupabaseService
    {
        private readonly Supabase.Client _client;

        public SupabaseService()
        {
            var url = "https://urafaskxxxpxyhqhhsvr.supabase.co";
            var key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InVyYWZhc2t4eHhweHlocWhoc3ZyIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NTk1MDkzMTgsImV4cCI6MjA3NTA4NTMxOH0.4_GEtl8HvzID1Igtli10NKtpxmpeXjkWImivNYA9XCM";

            _client = new Supabase.Client(url, key, new SupabaseOptions
            {
                AutoConnectRealtime = true
            });
        }

        // Métodos para Citas
        public async Task<List<Cita>> ObtenerCitasAsync()
        {
            var response = await _client.From<Cita>().Get();
            return response.Models;
        }

        public async Task InsertarCitaAsync(Cita cita)
        {
            await _client.From<Cita>().Insert(cita);
        }

        // ✅ Nuevos métodos para Pacientes
        public async Task<List<Paciente>> ObtenerPacientesAsync()
        {
            var response = await _client.From<Paciente>().Get();
            return response.Models;
        }

        public async Task<Paciente> ObtenerPacientePorIdAsync(Guid id)
        {
            var response = await _client.From<Paciente>()
                .Where(p => p.Id == id)
                .Single();
            return response;
        }

        public async Task InsertarPacienteAsync(Paciente paciente)
        {
            await _client.From<Paciente>().Insert(paciente);
        }

        public async Task ActualizarPacienteAsync(Paciente paciente)
        {
            await _client.From<Paciente>().Update(paciente);
        }

        public async Task EliminarPacienteAsync(Guid id)
        {
            await _client.From<Paciente>()
                .Where(p => p.Id == id)
                .Delete();
        }
    }
}