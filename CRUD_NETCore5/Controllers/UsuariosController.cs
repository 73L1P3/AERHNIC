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

        [HttpPost]
        public IActionResult GetUsuarios(string nombreUsuario, string clave)
        {
            var usuario = _context.Usuarios.Where(x => x.Nombre_Usuario == nombreUsuario && x.Clave_Usuario == clave);

            if (usuario.Any())
            {
                if (usuario.Where(x => x.Nombre_Usuario == nombreUsuario && x.Clave_Usuario == clave).Any())
                {
                    return Json(new { Status = true, message = "Bienvenido" });
                } else
                {
                    return Json(new { Status = false, message = "Clave Incorrecto" });
                }
            } else
            {
                return Json(new { Status = false, message = "Usuario Incorrecto" });
            }           
        }
    }
}
