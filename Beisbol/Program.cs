using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beisbol
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> Equipos = new List<Equipo>();

            Equipo Yaquis = new Equipo("Yaquis", "Cajeme", "Federico");
            Equipo Mayos = new Equipo("Mayos", "Navojoa", "Guzmán");

            Equipos.Add(Yaquis);
            Equipos.Add(Mayos);

            Jugador a1 = new Jugador("Jesus", "1");
            Jugador a2 = new Jugador("Jose", "2");
            Jugador a3 = new Jugador("Jorge", "3");
            Jugador a4 = new Jugador("Julio", "4");
            Jugador a5 = new Jugador("Jeremías", "5");
            Jugador a6 = new Jugador("Jason", "6");
            Jugador a7 = new Jugador("Josue", "7");
            Jugador a8 = new Jugador("Jota", "8");
            Jugador a9 = new Jugador("Juan", "9");
            Jugador b1 = new Jugador("Benito", "21");
            Jugador b2 = new Jugador("Guillermo", "22");
            Jugador b3 = new Jugador("Francisco", "23");
            Jugador b4 = new Jugador("Pablo", "24");
            Jugador b5 = new Jugador("Miguel", "25");
            Jugador b6 = new Jugador("Carlos", "26");
            Jugador b7 = new Jugador("Ochoa", "27");
            Jugador b8 = new Jugador("Andrés", "28");
            Jugador b9 = new Jugador("Adan", "29");

            Yaquis.Jugadores.Add(a1);
            Yaquis.Jugadores.Add(a2);
            Yaquis.Jugadores.Add(a3);
            Yaquis.Jugadores.Add(a4);
            Yaquis.Jugadores.Add(a5);
            Yaquis.Jugadores.Add(a6);
            Yaquis.Jugadores.Add(a7);
            Yaquis.Jugadores.Add(a8);
            Yaquis.Jugadores.Add(a9);
            Mayos.Jugadores.Add(b1);
            Mayos.Jugadores.Add(b2);
            Mayos.Jugadores.Add(b3);
            Mayos.Jugadores.Add(b4);
            Mayos.Jugadores.Add(b5);
            Mayos.Jugadores.Add(b6);
            Mayos.Jugadores.Add(b7);
            Mayos.Jugadores.Add(b8);
            Mayos.Jugadores.Add(b9);

            foreach(Equipo equipo in Equipos)
            {
                Console.WriteLine("\nNombre del Equipo: " + equipo.Nombre);
                Console.WriteLine("\nNombre del entrenador: " + equipo.Entrenador); 
                Console.WriteLine("\nLista de los jugadores\n");
                foreach(Jugador jugador in equipo.Jugadores)
                {
                    Console.WriteLine("Nombre: " + jugador.Nombre + " Número:" + jugador.Numero);
                }
            }

            Console.Read();

        }
    }
}
