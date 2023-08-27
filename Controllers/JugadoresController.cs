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
        private static List<Jugadores> ListaJugadores = new List<Jugadores>();
        public IActionResult Index() {
            ViewBag.TiempoInscripcions = new List<string> { "6 meses", "12 meses", "18 meses", "24 meses" };
            List<string> categorias = new List<string> { "Sub 17", "Sub 20", "Mayores" };
            ViewBag.Categorias = categorias;
            ViewBag.Clubs = new List<string>{ "Universitario", "Alianza Lima","Sporting Cristal","FBC Melgar","Cienciano","Deportivo Municipal", "Sport Boys","César Vallejo", "Ayacucho FC","Sport Huancayo"};
            ViewBag.Temporadas = new List<string>{ "1", "2","3","4"};
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarJugador(Jugadores objJugadores) {
            ViewBag.TiempoInscripcions = new List<string> { "6 meses", "12 meses", "18 meses", "24 meses" };
            List<string> categorias = new List<string> { "Sub 17", "Sub 20", "Mayores" };
            ViewBag.Categorias = categorias;
            ViewBag.Clubs = new List<string>{ "Universitario", "Alianza Lima","Sporting Cristal","FBC Melgar","Cienciano","Deportivo Municipal", "Sport Boys","César Vallejo", "Ayacucho FC","Sport Huancayo"};
            ViewBag.Temporadas = new List<string>{ "1", "2","3","4"};

            // Aquí calculamos el monto total antes de mostrar la vista
            objJugadores.CalcularMontoTotal();
            ListaJugadores.Add(objJugadores);
            ViewData["Message"] = "Nombres y Apellidos: " + objJugadores.Nombre + " " + objJugadores.Apellidos;
            ViewData["Message1"] = "Cantidad de Temporadas: " + objJugadores.Temporada;
            ViewData["Message2"] = "Tiempo de Inscripción: " + objJugadores.TiempoInscripcion;
            ViewData["Message3"] = "Impuesto Total: " +  (objJugadores.TotaldeImpuesto?.ToString("C") ?? "0.00");
            ViewData["Message4"] = "Monto total a pagar: " +  (objJugadores.MontoTotal?.ToString("C") ?? "0.00");
            ViewData["Message5"] = "Para mas información puedes ver la lista de jugadores.";
            return View("Index");
        }

        public IActionResult Lista() {
            return View(ListaJugadores);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View("Error!");
        }
    }
}