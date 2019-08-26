using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beisbol
{
    class Equipo
    {
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Entrenador { get; set; }
        public List<Jugador> Jugadores { get; set; }

        public Equipo(string nombre, string ciudad, string entrenador)
        {
            Nombre = nombre;
            Ciudad = ciudad;
            Entrenador = entrenador;
            Jugadores = new List<Jugador>();
        }

    }
}
