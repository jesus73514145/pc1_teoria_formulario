using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pc1_teoria_formulario.Models {
    public class Jugadores {

        public string? TiempoInscripcion { get; set; }
        public string? Nombre { get; set; }
        public int? Edad { get; set; }
        public string? Genero { get; set; }
        public string? Email { get; set; }
        public string? Categoria { get; set; }
        
        public string? Club { get; set; } // Nuevo atributo
        public string? Temporada { get; set; }

    }
}