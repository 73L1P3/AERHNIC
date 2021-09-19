using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_NETCore5.Models
{
    public class Libro
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Titulo es obligatorio.")]
        [StringLength(50, ErrorMessage = "El {0} deber ser almenos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Titulo")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "La Descripcion es obligatoria.")]
        [StringLength(50, ErrorMessage = "El {0} deber ser almenos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La Fecha de Lanzamiento es obligatoria.")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Lanzamiento")]
        public DateTime Fecha_Lanzamiento { get; set; }

        [Required(ErrorMessage = "El Autor es obligatorio.")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "El Precio es obligatorio.")]
        public int Precio { get; set; }
    }
}
