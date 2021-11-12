using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_TorneoPRO;

namespace Frm_TorneoPRO
{
    public partial class Frm_Reportes : Form
    {
        OpenFileDialog openFile = new OpenFileDialog();
        SaveFileDialog saveFile = new SaveFileDialog();
        private int filtro;

        public Frm_Reportes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Precarga los datos necesarios antes de abrir el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Estadistica_Load(object sender, EventArgs e)
        {
            this.openFile.Filter = "Text Files |*.txt|Json File |*.json|Xml Files |*.xml";
            this.saveFile.Filter = "Text Files |*.txt|Json File |*.json|Xml Files |*.xml";
            lbl_NombreTorneo.Text = TorneoPro.NombreTorneo;
            lbl_Patrocinio.Text = TorneoPro.Patrocinio;
            lbl_Premio.Text = $"U$D{TorneoPro.Premio.ToString()}";
            rtb_Analisis.Text = Estadistica.AnalisisDeDatos();

        }

        /// <summary>
        /// Vuelve al home
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Reporta el campeon del torneo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception_Archivo">Error en guardar archivo txt</exception>
        /// <exception cref="Exception_SerializacionJson">Error en serializacion o deserializacion de un json</exception>
        /// <exception cref="Exception_SerializacionXml">Error en serializacion o deserializacion de un xml</exception>
        private void btn_Campeon_Click(object sender, EventArgs e)
        {
            try
            {
                gpb_Listas.Text = "Campeón del torneo";
                rtb_lista.Text = Jugador.Campeon(TorneoPro.ListaJugadores).ToString();
                filtro = 1;
            }            
            catch (Exception auxEx)
            {
                MessageBox.Show(auxEx.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Reporta como salio cada jugador en el torneo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception_Archivo">Error en guardar archivo txt</exception>
        /// <exception cref="Exception_SerializacionJson">Error en serializacion o deserializacion de un json</exception>
        /// <exception cref="Exception_SerializacionXml">Error en serializacion o deserializacion de un xml</exception>
        private void btn_EstadisticaJugadores_Click(object sender, EventArgs e)
        {            
            try
            {
                gpb_Listas.Text = "Posiciones del torneo";
                rtb_lista.Text = TorneoPro.Imprimir(Jugador.PorPuntos(TorneoPro.ListaJugadores));
                filtro = 2;
            }            
            catch (Exception auxEx)
            {
                MessageBox.Show(auxEx.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Reporta como los mas asesinos del torneo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception_Archivo">Error en guardar archivo txt</exception>
        /// <exception cref="Exception_SerializacionJson">Error en serializacion o deserializacion de un json</exception>
        /// <exception cref="Exception_SerializacionXml">Error en serializacion o deserializacion de un xml</exception>
        private void btn_MasKillers_Click(object sender, EventArgs e)
        {
            try
            {
                gpb_Listas.Text = "Top 5: Más Killers";
                rtb_lista.Text = TorneoPro.Imprimir(Jugador.MasKills(TorneoPro.ListaJugadores));
                filtro = 3;
            }            
            catch (Exception auxEx)
            {
                MessageBox.Show(auxEx.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Reporta los peores jugadores en el torneo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception_Archivo">Error en guardar archivo txt</exception>
        /// <exception cref="Exception_SerializacionJson">Error en serializacion o deserializacion de un json</exception>
        /// <exception cref="Exception_SerializacionXml">Error en serializacion o deserializacion de un xml</exception>
        private void btn_MasMancos_Click(object sender, EventArgs e)
        {
            try
            {
                gpb_Listas.Text = "Top 5: Más Mancos";
                rtb_lista.Text = TorneoPro.Imprimir(Jugador.MasMancos(TorneoPro.ListaJugadores));
                filtro = 4;
            }            
            catch (Exception auxEx)
            {
                MessageBox.Show(auxEx.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Reporta los que juegan por primera vez el torneo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception_Archivo">Error en guardar archivo txt</exception>
        /// <exception cref="Exception_SerializacionJson">Error en serializacion o deserializacion de un json</exception>
        /// <exception cref="Exception_SerializacionXml">Error en serializacion o deserializacion de un xml</exception>
        private void btn_PrimerTorneo_Click(object sender, EventArgs e)
        {
            try
            {
                gpb_Listas.Text = "Juegan primera vez el torneo";
                rtb_lista.Text = TorneoPro.Imprimir(Jugador.ListaPrimerTorneo(TorneoPro.ListaJugadores));
                filtro = 5;
            }
            catch (Exception auxEx)
            {
                MessageBox.Show(auxEx.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Reporta los que plantaron mas bombas en el torneo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception_Archivo">Error en guardar archivo txt</exception>
        /// <exception cref="Exception_SerializacionJson">Error en serializacion o deserializacion de un json</exception>
        /// <exception cref="Exception_SerializacionXml">Error en serializacion o deserializacion de un xml</exception>
        private void btn_Bombarderos_Click(object sender, EventArgs e)
        {
            try
            {
                gpb_Listas.Text = "Top 5: Plantadores de bombas";
                rtb_lista.Text = TorneoPro.Imprimir(Jugador.Bombarderos(TorneoPro.ListaJugadores));
                filtro = 6;
            }
            catch (Exception auxEx)
            {
                MessageBox.Show(auxEx.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Reporta los que rescataron mas rehenes en el torneo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception_Archivo">Error en guardar archivo txt</exception>
        /// <exception cref="Exception_SerializacionJson">Error en serializacion o deserializacion de un json</exception>
        /// <exception cref="Exception_SerializacionXml">Error en serializacion o deserializacion de un xml</exception>
        private void btn_Rescatistas_Click(object sender, EventArgs e)
        {
            try
            {
                gpb_Listas.Text = "Top 5: Rescatistas de rehenes";
                rtb_lista.Text = TorneoPro.Imprimir(Jugador.Rescatistas(TorneoPro.ListaJugadores));
                filtro = 7;
                
            }
            catch (Exception_Archivo eArchivo)
            {
                MessageBox.Show(eArchivo.Message, "ERROR al guardar txt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception_SerializacionJson eSerializacionJson)
            {
                MessageBox.Show(eSerializacionJson.Message, "ERROR al guardar json", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception_SerializacionXml eSerializacionXml)
            {
                MessageBox.Show(eSerializacionXml.Message, "ERROR al guardar xml", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception auxEx)
            {
                MessageBox.Show(auxEx.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Reporta los jugadores especialistas XXL con mas headshots en el torneo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception_Archivo">Error en guardar archivo txt</exception>
        /// <exception cref="Exception_SerializacionJson">Error en serializacion o deserializacion de un json</exception>
        /// <exception cref="Exception_SerializacionXml">Error en serializacion o deserializacion de un xml</exception>
        private void btn_Headshot_Click(object sender, EventArgs e)
        {
            try
            {
                gpb_Listas.Text = "XXL: Más headshots";
                rtb_lista.Text = TorneoPro.Imprimir(Jugador.XxlHeadshots(TorneoPro.ListaJugadores));
                filtro = 8;
            }            
            catch (Exception auxEx)
            {
                MessageBox.Show(auxEx.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Reporta el jugador mas joven del torneo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception_Archivo">Error en guardar archivo txt</exception>
        /// <exception cref="Exception_SerializacionJson">Error en serializacion o deserializacion de un json</exception>
        /// <exception cref="Exception_SerializacionXml">Error en serializacion o deserializacion de un xml</exception>
        private void btn_ElMenor_Click(object sender, EventArgs e)
        {
            try
            {
                gpb_Listas.Text = "El menor del torneo";
                rtb_lista.Text = Jugador.MasJoven(TorneoPro.ListaJugadores).ToString();
                filtro = 9;               
            }
            catch (Exception auxEx)
            {
                MessageBox.Show(auxEx.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Abre la opcion para poner el nombre, elegir la extension y guardar el archivo en la ruta seleccionada
        /// </summary>
        /// <param name="tipo">Nombre del parametro</param>
        private void GuardarComo(Jugador tipo)
        {
            this.saveFile.FileName = string.Empty;
            this.saveFile.ShowDialog();
            if (this.saveFile.FileName != String.Empty)
            {
                if (Path.GetExtension(this.saveFile.FileName) == ".txt")
                {
                    try
                    {
                        Archivo<Jugador>.Escribir(tipo, this.saveFile.FileName);
                    }
                    catch (Exception_Archivo ex)
                    {
                        MessageBox.Show(ex.Message, "Error en archivo txt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Path.GetExtension(this.saveFile.FileName) == ".json")
                {
                    try
                    {
                        SerializacionJson<Jugador>.Escribir(tipo, this.saveFile.FileName);
                    }
                    catch (Exception_SerializacionJson ex)
                    {
                        MessageBox.Show(ex.Message, "Error en archivo json", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Path.GetExtension(this.saveFile.FileName) == ".xml")
                {
                    try
                    {
                        SerializacionXml<Jugador>.Escribir(tipo, this.saveFile.FileName);
                    }
                    catch (Exception_SerializacionXml ex)
                    {
                        MessageBox.Show(ex.Message, "Error en archivo xml", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                this.openFile.FileName = this.saveFile.FileName;
                Mensaje();
            }
        }

        /// <summary>
        /// Abre la opcion para poner el nombre, elegir la extension y guardar el archivo en la ruta seleccionada
        /// </summary>
        /// <param name="tipo">Nombre del parametro</param>
        private void GuardarComo(List<Jugador> tipo)
        {
            this.saveFile.FileName = string.Empty;
            this.saveFile.ShowDialog();
            if (this.saveFile.FileName != String.Empty)
            {
                if (Path.GetExtension(this.saveFile.FileName) == ".txt")
                {
                    try
                    {
                        Archivo<List<Jugador>>.Escribir(TorneoPro.Imprimir(tipo), this.saveFile.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Path.GetExtension(this.saveFile.FileName) == ".json")
                {
                    try
                    {
                        SerializacionJson<List<Jugador>>.Escribir(tipo, this.saveFile.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Path.GetExtension(this.saveFile.FileName) == ".xml")
                {
                    try
                    {
                        SerializacionXml<List<Jugador>>.Escribir(tipo, this.saveFile.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                this.openFile.FileName = this.saveFile.FileName;
                Mensaje();
            }
        }

        /// <summary>
        /// Abre la opcion para poner el nombre, elegir la extension y guardar el archivo en la ruta seleccionada
        /// </summary>
        /// <param name="tipo">tipo parametro string</param>
        private void GuardarComo(string tipo)
        {
            this.saveFile.FileName = string.Empty;
            this.saveFile.ShowDialog();
            if (this.saveFile.FileName != String.Empty)
            {
                if (Path.GetExtension(this.saveFile.FileName) == ".txt")
                {
                    try
                    {
                        Archivo<string>.Escribir(tipo, this.saveFile.FileName);
                    }
                    catch (Exception_Archivo ex)
                    {
                        MessageBox.Show(ex.Message, "Error en archivo txt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Path.GetExtension(this.saveFile.FileName) == ".json")
                {
                    try
                    {
                        SerializacionJson<string>.Escribir(tipo, this.saveFile.FileName);
                    }
                    catch (Exception_SerializacionJson ex)
                    {
                        MessageBox.Show(ex.Message, "Error en archivo json", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Path.GetExtension(this.saveFile.FileName) == ".xml")
                {
                    try
                    {
                        SerializacionXml<string>.Escribir(tipo, this.saveFile.FileName);
                    }
                    catch (Exception_SerializacionXml ex)
                    {
                        MessageBox.Show(ex.Message, "Error en archivo xml", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                this.openFile.FileName = this.saveFile.FileName;
                Mensaje();
            }
        }

        /// <summary>
        /// cartel de mensaje si se exporto correctamente
        /// </summary>
        private void Mensaje()
        {
            Frm_Mensaje mensaje = new Frm_Mensaje("Archivo guardado\nEXITOSAMENTE!");
            mensaje.BackColor = Color.FromArgb(222,40,50); ;
            mensaje.ShowDialog();
        }

        /// <summary>
        /// Exportar los listados filtrados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Exportar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (filtro)
                {
                    case 1:
                        GuardarComo(Jugador.Campeon(TorneoPro.ListaJugadores));
                        break;
                    case 2:
                        GuardarComo(Jugador.PorPuntos(TorneoPro.ListaJugadores));
                        break;
                    case 3:
                        GuardarComo(Jugador.MasKills(TorneoPro.ListaJugadores));
                        break;
                    case 4:
                        GuardarComo(Jugador.MasMancos(TorneoPro.ListaJugadores));
                        break;
                    case 5:
                        GuardarComo(Jugador.ListaPrimerTorneo(TorneoPro.ListaJugadores));
                        break;
                    case 6:
                        GuardarComo(Jugador.Bombarderos(TorneoPro.ListaJugadores));
                        break;
                    case 7:
                        GuardarComo(Jugador.Rescatistas(TorneoPro.ListaJugadores));
                        break;
                    case 8:
                        GuardarComo(Jugador.XxlHeadshots(TorneoPro.ListaJugadores));
                        break;
                    case 9:
                        GuardarComo(Jugador.MasJoven(TorneoPro.ListaJugadores));
                        break;
                }
            }
            catch (Exception_Archivo eArchivo)
            {
                MessageBox.Show(eArchivo.Message, "ERROR al guardar txt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception_SerializacionJson eSerializacionJson)
            {
                MessageBox.Show(eSerializacionJson.Message, "ERROR al guardar json", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception_SerializacionXml eSerializacionXml)
            {
                MessageBox.Show(eSerializacionXml.Message, "ERROR al guardar xml", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception auxEx)
            {
                MessageBox.Show(auxEx.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ExportarAnálisis_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarComo(Estadistica.AnalisisDeDatos());
            }
            catch (Exception_Archivo eArchivo)
            {
                MessageBox.Show(eArchivo.Message, "ERROR al guardar txt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception_SerializacionJson eSerializacionJson)
            {
                MessageBox.Show(eSerializacionJson.Message, "ERROR al guardar json", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception_SerializacionXml eSerializacionXml)
            {
                MessageBox.Show(eSerializacionXml.Message, "ERROR al guardar xml", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception auxEx)
            {
                MessageBox.Show(auxEx.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
