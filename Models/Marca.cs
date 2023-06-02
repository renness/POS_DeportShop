using System.ComponentModel.DataAnnotations;
namespace POS_DeportShop.Models
{
    public class Marca
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Logo { get; set; }

        public bool Estado { get; set; }

        public IEnumerable<Producto> Productos { get; set; }
    }
}
