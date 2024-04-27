using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using examen_gestion_cuenta_bancarias.Models;
using examen_gestion_cuenta_bancarias.Data;

namespace examen_gestion_cuenta_bancarias.Controllers
{
    public class Registro_cuentabController : Controller
    {

       private readonly ILogger<Registro_cuentabController> _logger;
        private readonly ApplicationDbContext _context;


        public Registro_cuentabController(ILogger<Registro_cuentabController> logger,ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnviarMensaje(Registro_cuentab objcontato)
        {
            _logger.LogDebug("Ingreso");

            //Se registran los datos del objeto a la base datos
            _context.Add(objcontato);
            _context.SaveChanges();

            ViewData["Message"] = "Se registro la cuenta";
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}