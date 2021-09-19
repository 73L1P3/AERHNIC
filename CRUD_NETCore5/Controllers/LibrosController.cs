using CRUD_NETCore5.Data;
using CRUD_NETCore5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_NETCore5.Controllers
{
    public class LibrosController : Controller
    {

        private readonly ApplicationDbContext _context;

        public LibrosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Libro> lstLibro = _context.Libro;
            return View(lstLibro);
        }

        // HTTP Get Create
        public IActionResult Create()
        {
            return View();
        }

        // HTTP POST Create
        [HttpPost]
        public IActionResult Create(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _context.Libro.Add(libro);
                _context.SaveChanges();
            }
            return View();
        }
    }
}
