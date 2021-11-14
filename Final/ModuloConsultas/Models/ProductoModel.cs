using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloConsultas.Models
{
    public class ProductoModel
    {
        //Atributos de clase
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name ="Codigo de producto")]
        [Required]
        public int CodigoProducto { get; set; }
        /********************************/
        [Column(TypeName ="varchar(35)")]
        [Display(Name = "Nombre de producto")]
        [Required]
        public string NombreProducto { get; set; }
        /********************************/
        [Display(Name = "Exitencias de producto")]
        [Required]
        public int CantidadProducto { get; set; }
        /********************************/
        [Display(Name = "Fecha de ingreso")]
        [Column(TypeName = "varchar(35)")]
        [Required]
        public string FechaIngreso { get; set; }
        /********************************/
        [Column(TypeName = "varchar(35)")]
        [Display(Name = "Fecha de vencimiento")]
        [Required]
        public string FechaVencimiento { get; set; }
        /********************************/
        [Display(Name = "Codigo de proveedor")]
        [Required]
        public int CodigoProveedor { get; set; }
        /********************************/
        [Column(TypeName = "varchar(35)")]
        [Display(Name = "Nombre proveedor")]
        [Required]
        public string NombreProveedor { get; set; }
    }
}
