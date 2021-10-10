using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AERHNIC.Models
{
    public class Users_in_Roles
    {
        [Key]
        public Guid Id_User_Role { get; set; }
        public Roles Roles { get; set; }
        public Usuarios Usuarios { get; set; }
    }
}
