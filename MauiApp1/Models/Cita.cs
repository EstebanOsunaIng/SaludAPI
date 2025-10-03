using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace MauiApp1.Models
{
    [Table("citas")] // nombre exacto de la tabla en Supabase
    public class Cita : BaseModel
    {
        [PrimaryKey("id")]
        public Guid Id { get; set; }   // UUID en la BD

        [Column("paciente")]
        public string Paciente { get; set; } = string.Empty;

        [Column("doctor")]
        public string Doctor { get; set; } = string.Empty;

        [Column("fecha")]
        public DateTime Fecha { get; set; }

        [Column("hora")]
        public TimeSpan Hora { get; set; } // "time" en PostgreSQL -> TimeSpan en .NET

        [Column("motivo")]
        public string Motivo { get; set; } = string.Empty;
    }
}
