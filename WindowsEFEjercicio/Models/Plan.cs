using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEjercicio.Models
{

    [Table("Plan")]
    public class Plan
    {

        [Key]
        public int IdPlan { get; set; }
        public int IdCarrera { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }

        #region navegacion

        [ForeignKey("IdCarrera")]
        public Carrera Carrera { get; set; }

        #endregion

    }
}
