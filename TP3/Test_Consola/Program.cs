using System;
using System.Collections.Generic;
using Entidades_TorneoPRO;

namespace Test_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Jugador> jugadores = new List<Jugador>();
            Jugador j1 = new Jugador(1, "Neil", 19, "Male", "Germany", "XXL", false);
            Jugador j2 = new Jugador(2, "Yoko", 20, "Female", "Japan", "S", true);
            Jugador j3 = new Jugador(3, "Juana", 33, "Female", "Uruguay", "L", false);
            Jugador j4 = new Jugador(4, "Janice", 43, "Female", "Canada", "L", false);
            Jugador j5 = new Jugador(5, "Peter", 15, "Male", "United State", "M", false);
            Jugador j6 = new Jugador(6, "Ann", 12, "Female", "China", "XXL", false);
            Jugador j7 = new Jugador(7, "Exeia", 45, "Female", "Suecia", "L", true);
            Jugador j8 = new Jugador(8, "Patricia", 28, "Female", "Argentina", "S", false);
            Jugador j9 = new Jugador(9, "Scott", 17, "Male", "UK", "M", false);
            Jugador j10 = new Jugador(10, "Rus", 40, "Male", "Belgium", "L", false);

            Console.WriteLine("*****************************************************************");
            Console.WriteLine($"                    {TorneoPro.NombreTorneo}");
            Console.WriteLine($"                    PATROCINADOR: {TorneoPro.Patrocinio}");
            Console.WriteLine($"                    PREMIO: U$D {TorneoPro.Premio}");
            Console.WriteLine("*****************************************************************");

            Console.WriteLine("\nJUGADORES ALISTANDOSE...");
            jugadores.Add(j1);
            jugadores.Add(j2);
            jugadores.Add(j3);
            jugadores.Add(j4);
            jugadores.Add(j5);
            jugadores.Add(j6);
            jugadores.Add(j7);
            jugadores.Add(j8);
            jugadores.Add(j9);
            jugadores.Add(j10);

            Console.WriteLine("SIMULANDO TORNEO...");
            Partida fullPartidas = new Partida();
            fullPartidas.SimularPartidas(jugadores);

            Console.WriteLine("GENERANDO REPORTES...");

            Console.WriteLine("\n*****************************************************************");
            Console.WriteLine("                     CAMPEON DEL TORNEO:");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine(Jugador.Campeon(jugadores));

            Console.WriteLine("\n*****************************************************************");
            Console.WriteLine("                     ESTADISTICAS POR PUNTOS:");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine(TorneoPro.Imprimir(Jugador.PorPuntos(jugadores)));

            Console.WriteLine("\n*****************************************************************");
            Console.WriteLine("                             MAS KILLS:");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine(TorneoPro.Imprimir(Jugador.MasKills(jugadores)));

            Console.WriteLine("\n*****************************************************************");
            Console.WriteLine("                             MAS MANCOS:");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine(TorneoPro.Imprimir(Jugador.MasMancos(jugadores)));

            Console.WriteLine("\n*****************************************************************");
            Console.WriteLine("                            PRIMER TORNEO:");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine(TorneoPro.Imprimir(Jugador.ListaPrimerTorneo(jugadores)));

            Console.WriteLine("\n*****************************************************************");
            Console.WriteLine("                    MAYORES PLANTADORES DE BOMBAS:");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine(TorneoPro.Imprimir(Jugador.Bombarderos(jugadores)));

            Console.WriteLine("\n*****************************************************************");
            Console.WriteLine("                    MAYORES RESCATISTAS DE REHENES:");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine(TorneoPro.Imprimir(Jugador.Rescatistas(jugadores)));

            Console.WriteLine("\n*****************************************************************");
            Console.WriteLine("                    JUGADORES XXL CON MAS HEADSHOTS:");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine(TorneoPro.Imprimir(Jugador.XxlHeadshots(jugadores)));

            Console.WriteLine("\n*****************************************************************");
            Console.WriteLine("                         JUGADOR MAS JOVEN:");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine(Jugador.MasJoven(jugadores));
        }
    }
}
