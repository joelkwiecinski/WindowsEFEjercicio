using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEjercicio.Models
{
    [Table("Detalle")]
    public class Detalle
    {

        [Key]
        public int IdDetalle { get; set; }
        public int IdPlanilla { get; set; }
        public int IdEstado { get; set; }


        #region navegacion

        [ForeignKey("IdEstado")]
        public Estado Estado { get; set; }

        [ForeignKey("IdPlanilla")]
        public Planilla Planilla { get; set; }

        public List<Evaluacion> Evaluaciones { get; set; }

        #endregion

    }
}
