
using System.ComponentModel.DataAnnotations;

namespace WebAPISolutionN.Models
{
    public class Curso
    {
        [Key]
        public int CursoId { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;

        public ICollection<Asignacion> Asignaciones { get; set; }
            = new List<Asignacion>();
    }
}
