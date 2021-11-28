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
            int killsT = 0;
            int muertesT = 0;
            int headshotsT = 0;
            int bombasT = 0;
            int rehenesT = 0;
            int nacionalidadLF = 0;
            int nacionalidadNLF = 0;
            int nacionalidadLM = 0;
            int nacionalidadNLM = 0;
            int cuerpoLatinoF = 0;
            int cuerpoLatinoM = 0;
            int cuerpoNoLatinoF = 0;
            int cuerpoNoLatinoM = 0;
            int primerTorneoSiTot = 0;
            int cuerpoT = 0;
            string formato = string.Empty;

            foreach (Jugador item in lista)
            {
                if (item.Genero.Trim() == "Female")
                {
                    female++;
                    if (item.Edad > 11 && item.Edad < 30) rangoEstarioFemUno++;
                    if (item.Edad > 29 && item.Edad < 50) rangoEstarioFemDos++;
                    if (item.Edad > 49 ) rangoEstarioFemTres++;
                    if (item.PrimerTorneo == true) primerTorneoSiFem++;
                    if (item.Nacionalidad == "Argentina" || item.Nacionalidad == "Brazil" || item.Nacionalidad == "Colombia" || item.Nacionalidad == "Mexico" || item.Nacionalidad == "Uruguay" || item.Nacionalidad == "Chile" || item.Nacionalidad == "Paraguay" || item.Nacionalidad == "Peru")
                    {
                        nacionalidadLF++;
                        if (item.Especialidad == "XS") cuerpoLatinoF++;
                    }
                    else
                    {
                        if (item.Especialidad == "XS") cuerpoNoLatinoF++;
                    }

                    killsF += item.Estadistica.Kills;
                    muertesF += item.Estadistica.Muerte;
                    headshotsF += item.Estadistica.Headshot;
                    bombasF += item.Estadistica.Bombas;
                    rehenesF += item.Estadistica.Rehenes;
                    
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
                    if (item.Nacionalidad == "Argentina" || item.Nacionalidad == "Brazil" || item.Nacionalidad == "Colombia" || item.Nacionalidad == "Mexico" || item.Nacionalidad == "Uruguay" || item.Nacionalidad == "Chile" || item.Nacionalidad == "Paraguay" || item.Nacionalidad == "Peru")
                    {
                        nacionalidadLM++;
                        if (item.Especialidad == "XS") cuerpoLatinoM++;
                    }
                    else
                    {
                        if (item.Especialidad == "XS") cuerpoNoLatinoM++;
                    }
                }
            }

            male = lista.Count - female;
            primerTorneoNoFem = female - primerTorneoSiFem;
            primerTorneoNoMen = male - primerTorneoSiMen;
            nacionalidadNLF = female - nacionalidadLF;
            nacionalidadNLM = male - nacionalidadLM;
            primerTorneoSiTot = primerTorneoSiMen + primerTorneoSiFem;

            killsT = killsF + killsM;
            muertesT = muertesF + muertesM;
            headshotsT = headshotsF + headshotsM;
            bombasT = bombasF + bombasM;
            rehenesT = rehenesF + rehenesM;
            cuerpoT = cuerpoNoLatinoM + cuerpoLatinoM;

            StringBuilder analisis = new StringBuilder();
            analisis.AppendLine(String.Format("*Participacion total del torneo  ------------ {0,4}", lista.Count));
            analisis.AppendLine(String.Format("\n*Categoria-------------Female----||----Male-----"));
            analisis.AppendLine(formato.MiFormato(titulo[0], female, (float)female * 100 / lista.Count, male, (float)male * 100 / lista.Count));
            analisis.AppendLine(String.Format("\n*Primer torneo -----------------------------------"));
            analisis.AppendLine(formato.MiFormato(titulo[1], primerTorneoSiFem, (float)primerTorneoSiFem * 100 / female, primerTorneoSiMen, (float)primerTorneoSiMen * 100 / male));
            analisis.AppendLine(formato.MiFormato(titulo[2], primerTorneoNoFem, (float)primerTorneoNoFem * 100 / female, primerTorneoNoMen, (float)primerTorneoNoMen * 100 / male));
            analisis.AppendLine(String.Format("\n*Rango etario ------------------------------------"));
            analisis.AppendLine(formato.MiFormato(titulo[3], rangoEstarioFemUno, (float)rangoEstarioFemUno * 100 / female, rangoEstarioMenUno, (float)rangoEstarioMenUno * 100 / male));
            analisis.AppendLine(formato.MiFormato(titulo[4], rangoEstarioFemDos, (float)rangoEstarioFemDos * 100 / female, rangoEstarioMenDos, (float)rangoEstarioMenDos * 100 / male));
            analisis.AppendLine(formato.MiFormato(titulo[5], rangoEstarioFemTres, (float)rangoEstarioFemTres * 100 / female, rangoEstarioMenTres, (float)rangoEstarioMenTres * 100 / male));
            analisis.AppendLine(String.Format("\n*Nacionalidad ------------------------------------"));
            analisis.AppendLine(formato.MiFormato(titulo[6], nacionalidadLF, (float)nacionalidadLF * 100 / female, nacionalidadLM, (float)nacionalidadLM * 100 / male));
            analisis.AppendLine(formato.MiFormato(titulo[7], nacionalidadNLF, (float)nacionalidadNLF * 100 / female, nacionalidadNLM, (float)nacionalidadNLM * 100 / male));
            analisis.AppendLine(String.Format("\n*Resultados KMHBR --------------------------------"));
            analisis.AppendLine(formato.MiFormato(titulo[8], killsF, (float)killsF * 100 / killsT, killsM, (float)killsM * 100 / killsT));
            analisis.AppendLine(formato.MiFormato(titulo[9], muertesF, (float)muertesF * 100 / muertesT, muertesM, (float)muertesM * 100 / muertesT));
            analisis.AppendLine(formato.MiFormato(titulo[10], headshotsF, (float)headshotsF * 100 / headshotsT, headshotsM, (float)headshotsM * 100 / headshotsT));
            analisis.AppendLine(formato.MiFormato(titulo[11], bombasF, (float)bombasF * 100 / bombasT, bombasM, (float)bombasM * 100 / bombasT));
            analisis.AppendLine(formato.MiFormato(titulo[12], rehenesF, (float)rehenesF * 100 / rehenesT, rehenesM, (float)rehenesM * 100 / rehenesT));
            analisis.AppendLine(String.Format("\n*Cruce de información ----------------------------"));

            if (headshotsF >= headshotsM)
                analisis.AppendLine(String.Format("\nLas mujeres ejecutan un {0,5:0.00}% más de headshots que los hombres.", ((float)headshotsF * 100 / headshotsT) - ((float)headshotsM * 100 / headshotsT)));
            else
                analisis.AppendLine(String.Format("\nLos hombres ejecutan un {0,5:0.00}% más de headshots que las mujeres.", ((float)headshotsM * 100 / headshotsT) - ((float)headshotsF * 100 / headshotsT)));

            if (killsF >= killsM)
                analisis.AppendLine(String.Format("\nLas mujeres ejecutan un {0,5:0.00}% más kills que los hombres.", ((float)killsF * 100 / killsT) - ((float)killsM * 100 / killsT)));
            else
                analisis.AppendLine(String.Format("\nLos hombres ejecutan un {0,5:0.00}% más kills que las mujeres.", ((float)killsM * 100 / killsT) - ((float)killsF * 100 / killsT)));

            if (muertesF >= muertesM)
                analisis.AppendLine(String.Format("\nLas mujeres murieron un {0,5:0.00}% más que los hombres.", ((float)muertesF * 100 / muertesT) - ((float)muertesM * 100 / muertesT)));
            else
                analisis.AppendLine(String.Format("\nLos hombres murieron un {0,5:0.00}% más que las mujeres.", ((float)muertesM * 100 / muertesT) - ((float)muertesF * 100 / muertesT)));

            if (cuerpoLatinoM >= cuerpoNoLatinoM)
                analisis.AppendLine(String.Format("\nLos hombres latinos prefieren el combate cuerpo a cuerpo un {0,5:0.00}% que los no latinos.", ((float)cuerpoLatinoM * 100 / cuerpoT) - ((float)cuerpoNoLatinoM * 100 / cuerpoT)));
            else
                analisis.AppendLine(String.Format("\nLos hombres no latinos prefieren el combate cuerpo a cuerpo un {0,5:0.00}% más que los latinos.", ((float)cuerpoNoLatinoM * 100 / cuerpoT) - ((float)cuerpoLatinoM * 100 / cuerpoT)));

            if (rangoEstarioFemTres >= rangoEstarioMenTres)
                analisis.AppendLine(String.Format("\nParticipan un {0,5:0.00}% más de mujeres que hombres +50 años.", ((float)rangoEstarioFemTres * 100 / female) - ((float)rangoEstarioMenTres * 100 / male)));
            else
                analisis.AppendLine(String.Format("\nParticipan un {0,5:0.00}% más de hombres que mujeres +50 años.", ((float)rangoEstarioMenTres * 100 / male) - ((float)rangoEstarioFemTres * 100 / female)));

            if (primerTorneoSiFem >= primerTorneoSiMen)
                analisis.AppendLine(String.Format("\nLas mujeres que jugaron su primer torneo son un {0,5:0.00}% más que los hombres.", ((float)primerTorneoSiFem * 100 / primerTorneoSiTot) - ((float)primerTorneoSiMen * 100 / primerTorneoSiTot)));
            else
                analisis.AppendLine(String.Format("\nLos hombres que jugaron su primer torneo son un {0,5:0.00}% más que las mujeres.", ((float)primerTorneoSiMen * 100 / primerTorneoSiTot) - ((float)primerTorneoSiFem * 100 / primerTorneoSiTot)));

            analisis.AppendLine(String.Format("\n-----------------------------------------------"));

            return analisis.ToString();
        }
    }
}
