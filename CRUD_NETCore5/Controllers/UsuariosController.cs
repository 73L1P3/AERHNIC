using CRUD_NETCore5.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AERHNIC.Controllers
{
    public class UsuariosController : Controller
    {
        // Accedemos a la base de datos
        private readonly ApplicationDbContext _context;

        // Constructor de Usuarios
        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
