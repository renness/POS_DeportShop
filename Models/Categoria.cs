using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS_DeportShop.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        public Categoria? CategoriaId { get; set; }

        public string Nombre { get; set; }

        public string? Descripcion { get; set; }

        public int Nivel { get; set; }

        public bool Estado { get; set; }

        public IEnumerable<Producto> Productos { get; set; }
    }
}
