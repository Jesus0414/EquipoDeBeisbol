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

            //Creamos los equipos
            Equipo Yaquis = new Equipo("Yaquis", "Ciudad Obregón", "Federico");
            Equipo Mayos = new Equipo("Mayos", "Navojoa", "Guzmán");
            
            //Guardamos a los jugadores en sus respectivo equipo
            Yaquis.Jugadores.Add(new Jugador("Jesus", 1));
            Yaquis.Jugadores.Add(new Jugador("Jose", 2));
            Yaquis.Jugadores.Add(new Jugador("Jorge", 3));
            Yaquis.Jugadores.Add(new Jugador("Julio", 4));
            Yaquis.Jugadores.Add(new Jugador("Jeremías", 5));
            Yaquis.Jugadores.Add(new Jugador("Jason", 6));
            Yaquis.Jugadores.Add(new Jugador("Josue", 7));
            Yaquis.Jugadores.Add(new Jugador("Jota", 8));
            Yaquis.Jugadores.Add(new Jugador("Juan", 9));
            Mayos.Jugadores.Add(new Jugador("Benito", 21));
            Mayos.Jugadores.Add(new Jugador("Guillermo", 22));
            Mayos.Jugadores.Add(new Jugador("Francisco", 23));
            Mayos.Jugadores.Add(new Jugador("Pablo", 24));
            Mayos.Jugadores.Add(new Jugador("Miguel", 25));
            Mayos.Jugadores.Add(new Jugador("Carlos", 26));
            Mayos.Jugadores.Add(new Jugador("Andrés", 27));
            Mayos.Jugadores.Add(new Jugador("Ochoa", 88));
            Mayos.Jugadores.Add(new Jugador("Adan", 29));

            //agregamos a los equipos
            Equipos.Add(Yaquis);
            Equipos.Add(Mayos);

            //ciclo de impresion
            foreach (Equipo equipo in Equipos)
            {
                Console.WriteLine("\nEquipo: " + equipo.Nombre + " De " + equipo.Ciudad);
                Console.WriteLine("\nEntrenador: " + equipo.Entrenador); 
                Console.WriteLine("\nLista de los jugadores\n");
                foreach(Jugador jugador in equipo.Jugadores)
                {
                    Console.WriteLine("-" + jugador.Nombre + " con el #" + jugador.Numero);
                }
            }

            Console.Read();

            /*Jugador a1 = new Jugador("Jesus", 1);
            Jugador a2 = new Jugador("Jose", 2);
            Jugador a3 = new Jugador("Jorge", 3);
            Jugador a4 = new Jugador("Julio", 4);
            Jugador a5 = new Jugador("Jeremías", 5);
            Jugador a6 = new Jugador("Jason", 6);
            Jugador a7 = new Jugador("Josue", 7);
            Jugador a8 = new Jugador("Jota", 8);
            Jugador a9 = new Jugador("Juan", 9);
            Jugador b1 = new Jugador("Benito", 21);
            Jugador b2 = new Jugador("Guillermo", 22);
            Jugador b3 = new Jugador("Francisco", 23);
            Jugador b4 = new Jugador("Pablo", 24);
            Jugador b5 = new Jugador("Miguel", 25);
            Jugador b6 = new Jugador("Carlos", 26);
            Jugador b7 = new Jugador("Ochoa", 27);
            Jugador b8 = new Jugador("Andrés", 28);
            Jugador b9 = new Jugador("Adan", 29);

            
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
            Mayos.Jugadores.Add(b9);*/
        }
    }
}
