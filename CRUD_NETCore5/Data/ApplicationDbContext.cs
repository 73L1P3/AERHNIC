using AERHNIC.Models;
//using CRUD_NETCore5.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_NETCore5.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Users_in_Roles> Users_in_Roles { get; set; }       
       
    }
}
