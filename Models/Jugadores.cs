using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pc1_teoria_formulario.Models {
    public class Jugadores {

        public string? TiempoInscripcion { get; set; }
        public string? Nombre { get; set; }
        public string? Apellidos { get; set; }
        public int? Edad { get; set; }
        public string? Genero { get; set; }
        public string? Email { get; set; }
        public string? Categoria { get; set; }
        
        public string? Club { get; set; } // Nuevo atributo
        public string? Temporada { get; set; }

        public decimal MontoTotal { get; set; } // Propiedad para almacenar el monto total calculado

        // Método para calcular el monto total a pagar
        public double CalcularMontoTotal() {
            double costoInscripcion = 0.0; // Costo de inscripción por 6 meses
            int numeroTemporadas = 0;

            switch(Temporada){
                case "1":
                    numeroTemporadas = 1; break;
                case "2":
                    numeroTemporadas = 2; break;
                case "3":
                    numeroTemporadas = 3; break;
                case "4":
                    numeroTemporadas = 4; break;
            }

            if(TiempoInscripcion.Equals("6 meses")){
                costoInscripcion = 300.0;
            } else if(TiempoInscripcion.Equals("12 meses")){
                costoInscripcion = 600.0;
            } else if(TiempoInscripcion.Equals("18 meses")){
                costoInscripcion = 900.0;
            } else{
                costoInscripcion = 1200.0;
            }

            return costoInscripcion * numeroTemporadas;
        }
    }
}