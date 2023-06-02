using System.ComponentModel.DataAnnotations;

namespace POS_DeportShop.Models
{
    public class Cliente
    {

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public string NroDoc { get; set; }

        public string Nombre { get; set; }

        public string? Telefono { get; set; }

        public string? Direccion { get; set; }

        public string? Detalle { get; set; }

        public bool Estado { get; set; }
    }
}
