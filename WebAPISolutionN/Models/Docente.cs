
using System.ComponentModel.DataAnnotations;

namespace WebAPISolutionN.Models
{
    public class Docente
    {
        [Key]
        public int DocenteId { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(50)]
        public string Nombres { get; set; } = string.Empty;

        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(50)]
        public string Apellidos { get; set; } = string.Empty;

        public ICollection<Asignacion> Asignaciones { get; set; }
            = new List<Asignacion>();
    }
}
