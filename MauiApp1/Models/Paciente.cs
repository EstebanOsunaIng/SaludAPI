using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace MauiApp1.Models
{
    [Table("pacientes")] // nombre exacto de la tabla en Supabase
    public class Paciente : BaseModel
    {
        [PrimaryKey("id")]
        public Guid Id { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; } = string.Empty;

        [Column("apellido")]
        public string Apellido { get; set; } = string.Empty;

        [Column("fecha_nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Column("telefono")]
        public string Telefono { get; set; } = string.Empty;

        [Column("email")]
        public string Email { get; set; } = string.Empty;

        [Column("direccion")]
        public string Direccion { get; set; } = string.Empty;

        [Column("tipo_sangre")]
        public string TipoSangre { get; set; } = string.Empty;

        // Propiedades calculadas
        public string NombreCompleto => $"{Nombre} {Apellido}";
        
        public int Edad
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - FechaNacimiento.Year;
                if (FechaNacimiento.Date > today.AddYears(-age)) age--;
                return age;
            }
        }
    }
}