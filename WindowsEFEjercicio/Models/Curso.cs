using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEjercicio.Models
{
    [Table("Curso")]
    public class Curso
    {

        [Key]
        public int IdCurso { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }

        #region navegacion

        public List<Planilla> Planillas { get; set; }

        #endregion

    }
}
