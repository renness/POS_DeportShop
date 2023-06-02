using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS_DeportShop.Models
{
    public class LogUsuario
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        
        public Usuario UsuarioId { get; set; }
        
        public string Detalle { get; set; }
        
        public DateTime FechaYHora { get; set; }
    }
}
