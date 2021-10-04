using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AERHNIC.Models
{
    public class Roles
    {
        [Key]
        public Guid IdRole { get; set; }

        [Required]
        [StringLength(50)]
        public String NombreRole { get; set; }
        public bool Status { get; set; }
        public List<Users_in_Roles> Users_in_Roles { get; set; }

    }
}
