using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEjercicio.Models
{

    [Table("Localidad")]
    public class Localidad
    {

        [Key]
        public int IdLocalidad { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }

        #region navegacion

        public List<Profesor> Profesores { get; set; }

        public List<Estudiante> Estudiantes { get; set; }

        #endregion

    }
}
