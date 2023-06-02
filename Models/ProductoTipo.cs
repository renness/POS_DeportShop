using System;
using System.ComponentModel.DataAnnotations;
namespace POS_DeportShop.Models
{
    public class ProductoTipo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "El campo Nombre debe tener un máximo de 50 caracteres")]
        public string Nombre { get; set; }

        [StringLength(150, ErrorMessage = "El campo Descripcion debe tener un máximo de 150 caracteres")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "El campo Estado es obligatorio")]
        public bool Estado { get; set; }

        public IEnumerable<Producto> Productos { get; set; }
    }
}





