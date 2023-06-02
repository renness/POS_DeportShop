using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS_DeportShop.Models
{
    public class Perfil
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public bool Estado { get; set; }

        public IEnumerable<Usuario> Usuarios { get; set; }
    }
}