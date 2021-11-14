using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloConsultas.Models
{
    public class BodegaModel
    {
        //Atributos de clase
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Display(Name = "Código Salida")]
        public int CodigoSalida { get; set; }

        [Required]
        [Display(Name = "Código proveedor")]
        public int CodigoProveedor { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de ingreso")]
        public DateTime FechaIngreso { get; set; }


        [Required]
        [Display(Name = "Existencia de producto")]
        public int ExistenciaProducto { get; set; }

    }
}
