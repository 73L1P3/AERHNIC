using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AERHNIC.Models
{
    public class Usuarios
    {
        [Key]
        public Guid UsuarioId { get; set; }   

        [Required(ErrorMessage = "El Nombre del Usuario es Requerido")]
        [StringLength(50, ErrorMessage = "El {0} debe de tener al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Nombre del Usuario")]
        public string Nombre_Usuario { get; set; }

        [Required(ErrorMessage = "El Correo del Usuario es Requerido")]
        [StringLength(50, ErrorMessage = "El {0} debe de tener al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Correo del Usuario")]
        public string Correo_Usuario { get; set; }

        [Required(ErrorMessage = "El Cargo del Usuario es Requerido")]
        [StringLength(50, ErrorMessage = "El {0} debe de tener al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Cargo del Usuario")]
        public string Cargo_Usuario { get; set; }

        [Required(ErrorMessage = "La Empresa del Usuario es Requerida")]
        [StringLength(50, ErrorMessage = "El {0} debe de tener al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Empresa del Usuario")]
        public string Empresa_Usuario { get; set; }

        [Required(ErrorMessage = "El Telefono Celular del Usuario es Requerido")]        
        [Display(Name = "Telefono Celular del Usuario")]
        public int Telefono_Celular_Usuario { get; set; }

        [Required(ErrorMessage = "El Telefono Empresarial del Usuario es Requerido")]
        [Display(Name = "Telefono Empresarial del Usuario")]
        public int Telefono_Empresa_Usuario { get; set; }

        [Required(ErrorMessage = "La Cedula del Usuario es Requerida")]
        [Display(Name = "Cedula del Usuario")]
        public string Cedula_Usuario { get; set; }

        [Required(ErrorMessage = "El Contacto de Pago es Requerido")]
        [Display(Name = "Contacto de Pago del Usuario")]
        public string Contacto_Pago_Usuario { get; set; }

        [Display(Name = "Comentario del Usuario")]
        public string Comentario_Usuario { get; set; }

        [Required(ErrorMessage = "La Fecha de Nacimiento es Requerida")]
        [Display(Name = "Fecha de Nacimiento del Usuario")]
        [DataType(DataType.Date)]
        public DateTime Fecha_Nacimiento_Usuario { get; set; }

        [Required(ErrorMessage = "La Fecha de Registro es Requerida")]
        [Display(Name = "Fecha de Registro del Usuario")]
        [DataType(DataType.Date)]
        public DateTime Registro_Usuario { get; set; }

        [Display(Name = "Estado del Usuario")]
        public string Estado_Usuario { get; set; }

        public List<Users_in_Roles> Users_in_Roles { get; set; }
    }
}
