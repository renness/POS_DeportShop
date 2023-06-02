using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS_DeportShop.Models
{
    public class Proveedor
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        
        public string Nit { get; set; }
        
        public string Nombre { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string? Telefono { get; set; }

        [EmailAddress]
        [Display(Name = "E-Mail")]
        public string? Email { get; set; }

        public string? Direccion { get; set; }

        public string? Detalle { get; set; }

        public bool Estado { get; set; }

        public IEnumerable<Producto> Productos { get; set; }
    }
}