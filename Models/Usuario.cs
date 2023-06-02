using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS_DeportShop.Models
{
    public class Usuario
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [EmailAddress]
        [Display(Name = "E-Mail")]
        [RegularExpression(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$", ErrorMessage = "Ingrese un Email valido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, MinimumLength = 3,
            ErrorMessage = "El Nombre de Usuario debe tener como minimo 3 caracteres y 50 como maximo")]
        [DataType(DataType.Text)]
        [Display(Name = "Usuario")]
        public string NombreUsuario { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string PassWord { get; set; }
                      
        public Perfil PerfilId { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "C.I.")]

        public Sucursal? SucursalId { get; set; }

        public string Ci { get; set; }

        [DataType(DataType.Text)]
        public string Nombre { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Inicio")]
        public DateTime FechaInicio { get; set; }
        
        public bool MantenerActivo { get; set; }

        public bool Estado { get; set; }

        public IEnumerable<LogUsuario>  LogsUsuario { get; set; }
    }
}