using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEjercicio.Models
{

    [Table("Planilla")]
    public class Planilla
    {

        [Key]
        public int IdPlanilla { get; set; }
        public int IdCarrera { get; set; }
        public int IdMateria { get; set; }
        public int IdProfesor { get; set; }
        public int IdCurso { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime Fecha { get; set; }


        #region navegacion

        public List<Detalle> Detalles { get; set; }

        [ForeignKey("IdCarrera")]
        public Carrera Carrera { get; set; }

        [ForeignKey("IdMateria")]
        public Materia Materia { get; set; }

        [ForeignKey("IdProfesor")]
        public Profesor Profesor { get; set; }

        [ForeignKey("IdCurso")]
        public Curso Curso { get; set; }

        #endregion

    }
}
