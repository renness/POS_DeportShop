using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS_DeportShop.Models
{
    public class Sucursal
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get ; set; }
        
        public string Direccion { get; set; }

        public string Ciudad { get; set; }
        
        public string? Descripcion { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string? Telefono { get; set; }

        [EmailAddress]
        [Display(Name = "E-Mail")]
        public string? Email { get; set; }
       
        public bool Estado { get; set; }

        public IEnumerable<Producto> Productos { get; set; }
    }
}
