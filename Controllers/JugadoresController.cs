using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pc1_teoria_formulario.Models;

namespace pc1_teoria_formulario.Controllers {

    public class JugadoresController : Controller  {
        private readonly ILogger<JugadoresController> _logger;

        public JugadoresController(ILogger<JugadoresController> logger) {
            _logger = logger;
        }

        public IActionResult Index() {
            ViewBag.TiempoInscripcions = new List<string> { "6 meses", "12 meses", "18 meses", "24 meses" };
            List<string> categorias = new List<string> { "Sub 17", "Sub 20", "Mayores" };
            ViewBag.Categorias = categorias;
            ViewBag.Clubs = new List<string>{ "Universitario", "Alianza Lima","Sporting Cristal","FBC Melgar","Cienciano","Deportivo Municipal", "Sport Boys","César Vallejo", "Ayacucho FC","Sport Huancayo"};
            ViewBag.Temporadas = new List<string>{ "1", "2","3","4"};
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarJugador(Jugadores jugadores) {

            ViewBag.TiempoInscripcions = new List<string> { "6 meses", "12 meses", "18 meses", "24 meses" };
            List<string> categorias = new List<string> { "Sub 17", "Sub 20", "Mayores" };
            ViewBag.Categorias = categorias;
            ViewBag.Clubs = new List<string>{ "Universitario", "Alianza Lima","Sporting Cristal","FBC Melgar","Cienciano","Deportivo Municipal", "Sport Boys","César Vallejo", "Ayacucho FC","Sport Huancayo"};
            ViewBag.Temporadas = new List<string>{ "1", "2","3","4"};

            ViewData["Message"] = "hola "+jugadores.TiempoInscripcion+" "+
            jugadores.Nombre+" "+jugadores.Edad+" "+jugadores.Genero
            +" "+jugadores.Email+" "+jugadores.Categoria+" "+jugadores.Club+
            " "+jugadores.Temporada;
            return View("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View("Error!");
        }
    }
}