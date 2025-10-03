using SaludAPI.Models;
using Supabase;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SaludAPI.Services
{
    public class SupabaseService
    {
        private readonly Client _client;

        public SupabaseService()
        {
            _client = new Client("https://urafaskxxxpxyhqhhsvr.supabase.co", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InVyYWZhc2t4eHhweHlocWhoc3ZyIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NTk1MDkzMTgsImV4cCI6MjA3NTA4NTMxOH0.4_GEtl8HvzID1Igtli10NKtpxmpeXjkWImivNYA9XCM");
        }

        public async Task<List<Cita>> GetCitasAsync()
        {
            var response = await _client.From<Cita>().Get();
            return response.Models;
        }

        public async Task AddCitaAsync(Cita cita)
        {
            await _client.From<Cita>().Insert(cita);
        }
    }
}
