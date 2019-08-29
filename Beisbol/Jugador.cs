using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beisbol
{
    class Jugador
    {
        public string Nombre { get; set; }
        public int Numero { get; set; }

        public Jugador()
        {
            Nombre = "Pendiente";
            Numero = 0;
        }

        public Jugador(string nombre, int numero)
        {
            Nombre = nombre;
            Numero = numero;
        }

    }
}
