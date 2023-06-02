using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace POS_DeportShop.Models
{
    public class Atributo
    {

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        
        [Display(Name = "Atributo")]
        public AtributoGrupo? AtributoGrupoId { get; set; }

        public string Valor { get; set; }

        public string Color { get; set; }

       
    }
}
