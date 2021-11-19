using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public class Estadistica
    {
        private int puntos;
        private int kills;
        private int muertes;
        private int headshot;
        private int bomba;
        private int rehenes;

        /// <summary>
        /// Propiedad readonly de puntos
        /// </summary>
        public int Puntos { get { return puntos; } }

        /// <summary>
        /// Propiedad readonly de kills
        /// </summary>
        public int Kills { get { return this.kills; } }

        /// <summary>
        /// Propiedad readonly de muerte propia
        /// </summary>
        public int Muerte { get { return this.muertes; }  }

        /// <summary>
        /// Propiedad readonly de headshot
        /// </summary>
        public int Headshot { get { return this.headshot; } }

        /// <summary>
        /// Propiedad readonly de bombas plantadas
        /// </summary>
        public int Bombas { get { return this.bomba; }  }

        /// <summary>
        /// Propiedad readonly de rehenes
        /// </summary>
        public int Rehenes { get { return this.rehenes; } }

        /// <summary>
        /// Constructor por defecto de estadistica
        /// </summary>
        public Estadistica()
        {

        }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="puntos">puntos obtenidos</param>
        /// <param name="kills">muertes ocasionadas</param>
        /// <param name="muertes">muertes recibidas</param>
        /// <param name="headshot">headshot hechos</param>
        /// <param name="bomba">bombas plantadas</param>
        /// <param name="rehenes">rehenes rescatados</param>
        public Estadistica(int puntos, int kills, int muertes, int headshot, int bomba, int rehenes) : this()
        {
            this.puntos = puntos;
            this.kills = kills;
            this.muertes = muertes;
            this.headshot = headshot;
            this.bomba = bomba;
            this.rehenes = rehenes;
        }



        /// <summary>
        /// Acumula los puntos por partida y las estadisticas
        /// </summary>
        /// <param name="kills">kills hechas</param>
        /// <param name="muertes">muertes recibidas</param>
        /// <param name="headshot">headshot hechas</param>
        /// <param name="bombas">bombas plantadas</param>
        /// <param name="rehenes">rehenes rescatados</param>
        public void Actualizar(int kills, int muertes, int headshot, int bombas, int rehenes)
        {
            int acumuladorPuntos = 0;

            this.kills += kills;
            this.muertes += muertes;
            this.headshot += headshot;
            this.bomba += bombas;
            this.rehenes += rehenes;

            acumuladorPuntos = (kills + (headshot * 2) + (bombas*3) + (rehenes*3)) - (muertes*2);
            this.puntos += acumuladorPuntos;
        }

        public static string AnalisisDeDatos(List<Jugador> lista)
        {
            string[] titulo = { "Genero:", "Si:", "No:", "de 12 a 29:",
                         "de 30 a 49:", "+ 50:", "Latinos", "No latinos", "Kills:", "Muertes:", "Headshots:", "Bombas:", "Rehenes:" };
            int female = 0;
            int male = 0;
            int primerTorneoSiFem = 0;
            int primerTorneoNoFem = 0;
            int primerTorneoSiMen = 0;
            int primerTorneoNoMen = 0;
            int rangoEstarioFemUno = 0;
            int rangoEstarioMenUno = 0;
            int rangoEstarioFemDos = 0;
            int rangoEstarioMenDos = 0;
            int rangoEstarioFemTres = 0;
            int rangoEstarioMenTres = 0;
            int killsF = 0;
            int muertesF = 0;
            int headshotsF = 0;
            int bombasF = 0;
            int rehenesF = 0;
            int killsM = 0;
            int muertesM = 0;
            int headshotsM = 0;
            int bombasM = 0;
            int rehenesM = 0;
            int nacionalidadLF = 0;
            int nacionalidadNLF = 0;
            int nacionalidadLM = 0;
            int nacionalidadNLM = 0;

            foreach (Jugador item in lista)
            {
                if (item.Genero.Trim() == "Female")
                {
                    female++;
                    if (item.Edad > 11 && item.Edad < 30) rangoEstarioFemUno++;
                    if (item.Edad > 29 && item.Edad < 50) rangoEstarioFemDos++;
                    if (item.Edad > 49 ) rangoEstarioFemTres++;
                    if (item.PrimerTorneo == true) primerTorneoSiFem++;
                    if (item.Nacionalidad == "Argentina" || item.Nacionalidad == "Brazil" || item.Nacionalidad == "Colombia" || item.Nacionalidad == "Mexico" || item.Nacionalidad == "Uruguay" || item.Nacionalidad == "Chile" || item.Nacionalidad == "Paraguay" || item.Nacionalidad == "Peru") nacionalidadLF++;

                    killsF += item.Estadistica.Kills;
                    muertesF += item.Estadistica.Muerte;
                    headshotsF += item.Estadistica.Headshot;
                    bombasF += item.Estadistica.Bombas;
                    rehenesF += item.Estadistica.Rehenes;
                    if (item.Nacionalidad == "Argentina" || item.Nacionalidad == "Brazil" || item.Nacionalidad == "Colombia" || item.Nacionalidad == "Mexico" || item.Nacionalidad == "Uruguay" || item.Nacionalidad == "Chile" || item.Nacionalidad == "Paraguay" || item.Nacionalidad == "Peru") nacionalidadLM++;
                }
                else
                {
                    if (item.Edad > 11 && item.Edad < 30) rangoEstarioMenUno++;
                    if (item.Edad > 29 && item.Edad < 50) rangoEstarioMenDos++;
                    if (item.Edad > 49) rangoEstarioMenTres++;
                    if (item.PrimerTorneo == true) primerTorneoSiMen++;
                    killsM += item.Estadistica.Kills;
                    muertesM += item.Estadistica.Muerte;
                    headshotsM += item.Estadistica.Headshot;
                    bombasM += item.Estadistica.Bombas;
                    rehenesM += item.Estadistica.Rehenes;
                }
            }

            male = lista.Count - female;
            primerTorneoNoFem = female - primerTorneoSiFem;
            primerTorneoNoMen = male - primerTorneoSiMen;
            nacionalidadNLF = female - nacionalidadLF;
            nacionalidadNLM = male - nacionalidadLM;

            StringBuilder analisis = new StringBuilder();
            analisis.AppendLine(String.Format("*Participacion total del torneo  ------------ {0,4}", lista.Count));
            analisis.AppendLine(String.Format("\n*Categoria----------------Female----||-----Male------"));
            analisis.AppendLine(String.Format("\n{0,-20}{1,5} | {2,5:0.00}%  ||{3,5} | {4,5:0.00}%", titulo[0], female, (float)female * 100 / lista.Count, male, (float)male * 100 / lista.Count));
            analisis.AppendLine(String.Format("\n*Primer torneo -------------------------------------"));
            analisis.AppendLine(String.Format("{0,-20}{1,5} | {2,5:0.00}%  ||{3,5} | {4,5:0.00}%", titulo[1], primerTorneoSiFem, (float)primerTorneoSiFem * 100 / female, primerTorneoSiMen, (float)primerTorneoSiMen * 100 / male));
            analisis.AppendLine(String.Format("{0,-20}{1,5} | {2,5:0.00}%  ||{3,5} | {4,5:0.00}%", titulo[2], primerTorneoNoFem, (float)primerTorneoNoFem * 100 / female, primerTorneoNoMen, (float)primerTorneoNoMen * 100 / male));
            analisis.AppendLine(String.Format("\n*Rango etario --------------------------------------"));
            analisis.AppendLine(String.Format("{0,-20}{1,5} | {2,5:0.00}%  ||{3,5} | {4,5:0.00}%", titulo[3], rangoEstarioFemUno, (float)rangoEstarioFemUno * 100 / female, rangoEstarioMenUno, (float)rangoEstarioMenUno * 100 / male));
            analisis.AppendLine(String.Format("{0,-20}{1,5} | {2,5:0.00}%  ||{3,5} | {4,5:0.00}%", titulo[4], rangoEstarioFemDos, (float)rangoEstarioFemDos * 100 / female, rangoEstarioMenDos, (float)rangoEstarioMenDos * 100 / male));
            analisis.AppendLine(String.Format("{0,-20}{1,5} | {2,5:0.00}%  ||{3,5} | {4,5:0.00}%", titulo[5], rangoEstarioFemTres, (float)rangoEstarioFemTres * 100 / female, rangoEstarioMenTres, (float)rangoEstarioMenTres * 100 / male));
            analisis.AppendLine(String.Format("\n*Nacionalidad --------------------------------------"));
            analisis.AppendLine(String.Format("{0,-20}{1,5} | {2,5:0.00}%  ||{3,5} | {4,5:0.00}%", titulo[6], nacionalidadLF, (float)nacionalidadLF * 100 / female, nacionalidadLM, (float)nacionalidadLM * 100 / male));
            analisis.AppendLine(String.Format("{0,-20}{1,5} | {2,5:0.00}%  ||{3,5} | {4,5:0.00}%", titulo[7], nacionalidadNLF, (float)nacionalidadNLF * 100 / female, nacionalidadNLM, (float)nacionalidadNLM * 100 / male));
            analisis.AppendLine(String.Format("\n*Promedios -----------------------------------------"));
            analisis.AppendLine(String.Format("{0,-20}{1,5} | {2,5:00.000}  ||{3,5} | {4,5:00.000}", titulo[8], killsF, (float)killsF / lista.Count, killsM, (float)killsM/ lista.Count));
            analisis.AppendLine(String.Format("{0,-20}{1,5} | {2,5:00.000}  ||{3,5} | {4,5:00.000}", titulo[9], muertesF, (float)muertesF / lista.Count, muertesM, (float)muertesM / lista.Count));
            analisis.AppendLine(String.Format("{0,-20}{1,5} | {2,5:00.000}  ||{3,5} | {4,5:00.000}", titulo[10], headshotsF, (float)headshotsF / lista.Count, headshotsM, (float)headshotsM / lista.Count));
            analisis.AppendLine(String.Format("{0,-20}{1,5} | {2,5:00.000}  ||{3,5} | {4,5:00.000}", titulo[11], bombasF, (float)bombasF / lista.Count, bombasM, (float)bombasM / lista.Count));
            analisis.AppendLine(String.Format("{0,-20}{1,5} | {2,5:00.000}  ||{3,5} | {4,5:00.000}", titulo[12], rehenesF, (float)rehenesF / lista.Count, rehenesM, (float)rehenesM / lista.Count));
            analisis.AppendLine(String.Format("\n----------------------------------------------------"));

            return analisis.ToString();
        }
    }
}
