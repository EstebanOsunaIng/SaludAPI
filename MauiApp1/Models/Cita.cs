using Postgrest.Attributes;
using Postgrest.Models;
using System;

namespace MauiApp1.Models
{
    [Table("citas")]
    public class Cita : BaseModel
    {
        [PrimaryKey("id")]
        public Guid Id { get; set; }   // UUID en Supabase

        [Column("paciente")]
        public string Paciente { get; set; }

        [Column("doctor")]
        public string Doctor { get; set; }

        [Column("fecha")]
        public DateTime Fecha { get; set; }

        [Column("hora")]
        public TimeSpan Hora { get; set; }  // PostgreSQL TIME → TimeSpan en .NET

        [Column("motivo")]
        public string Motivo { get; set; }
    }
}
