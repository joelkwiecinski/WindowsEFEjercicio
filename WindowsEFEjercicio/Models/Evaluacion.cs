using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEjercicio.Models
{

    [Table("Evaluacion")]
    public class Evaluacion
    {

        [Key]
        public int IdEvaluacion { get; set; }
        public int IdTipo { get; set; }
        public int IdEstudiante { get; set; }
        public int IdDetalle { get; set; }

        [Required]
        public double Nota { get; set; }

        #region navegacion

        [ForeignKey("IdEstudiante")]
        public Estudiante Estudiante { get; set; }

        [ForeignKey("IdTipo")]
        public Tipo Tipo { get; set; }

        [ForeignKey("IdDetalle")]
        public Detalle Detalle { get; set; }

        #endregion

    }
}
