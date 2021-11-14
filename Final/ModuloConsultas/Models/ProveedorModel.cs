using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloConsultas.Models
{
    public class ProveedorModel
    {
        //Atributos de clase
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Display(Name = "Código proveedor")]
        public int CodigoProveedor { get; set; }

        [Required]
        [Column(TypeName = "varchar(35)")]
        [Display(Name = "Nombre proveedor")]
        public string NombreProveedor { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        [Display(Name = "Nit Proveedor")]
        public string Nit { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        [Display(Name = "Dirección Proveedor")]
        public string Dirección { get; set; }
    }
}
