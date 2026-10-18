
using System.ComponentModel.DataAnnotations;

namespace WebAPISolutionN.Models
{
    public class Asignacion
    {
        [Key]
        public int AsignacionId { get; set; }

        [Required]
        public int EstudianteId { get; set; }

        [Required]
        public int CursoId { get; set; }

        [Required]
        public int DocenteId { get; set; }

        public Estudiante? Estudiante { get; set; }
        public Curso? Curso { get; set; }
        public Docente? Docente { get; set; }
    }
}
