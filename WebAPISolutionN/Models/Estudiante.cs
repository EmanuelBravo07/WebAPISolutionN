
using System.ComponentModel.DataAnnotations;

namespace WebAPISolutionN.Models
{
    public class Estudiante
    {
        [Key]
        public int EstudianteId { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(50)]
        public string Nombres { get; set; } = string.Empty;

        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(50)]
        public string Apellidos { get; set; } = string.Empty;

        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(100)]
        public string Direccion { get; set; } = string.Empty;

        public ICollection<Asignacion> Asignaciones { get; set; }
            = new List<Asignacion>();
    }
}
