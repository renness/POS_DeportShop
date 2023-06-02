using System.ComponentModel.DataAnnotations;

namespace POS_DeportShop.Models
{
    public class AtributoGrupo
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public bool EsColor { get; set; }

        public IEnumerable<Atributo> Atributos { get; set; }
    }
}
