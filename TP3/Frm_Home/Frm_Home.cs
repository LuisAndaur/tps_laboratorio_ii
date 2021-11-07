using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_TorneoPRO;


namespace Frm_TorneoPRO
{
    public partial class Frm_Home : Form
    {
        private SoundPlayer sonidoEntradaCarga;
        private bool flagSimulacion = false;

        public Frm_Home()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Precarga de metodos antes de abrir el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Home_Load(object sender, EventArgs e)
        {
            SonidoAmbiente();
        }

        /// <summary>
        /// Lanza un form para administrar a los jugadores ABM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AdministrarJugadores_Click(object sender, EventArgs e)
        {
            Frm_Administrador administrador = new Frm_Administrador();
            this.Hide();
            administrador.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Realiza una simulacion del torneo para realizar las estadisticas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception">Error si no se pudo simular</exception>
        private void btn_SimularTorneo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!flagSimulacion)
                {
                    Partida fullPartidas = new Partida();
                    fullPartidas.SimularPartidas(TorneoPro.ListaJugadores);
                    Frm_Simulador simular = new Frm_Simulador();
                    simular.ShowDialog();
                    flagSimulacion = true;
                }
                else
                {
                    MessageBox.Show("Ya se simuló el torneo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception auxEx)
            {

                MessageBox.Show(auxEx.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// Lanza un form con los reportes del torneo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Reportes_Click(object sender, EventArgs e)
        {
            if (flagSimulacion)
            {
                Frm_Reportes estadistica = new Frm_Reportes();
                this.Hide();
                estadistica.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Debe simular el torneo antes de ver los reportes", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Cierra la app por completo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Salir_Click(object sender, EventArgs e)
        {            
            Close();
        }

        /// <summary>
        /// Antes de cerrar pregunta si realmente deseamos cerrar la app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }                
        }        

        /// <summary>
        /// Carga la musica de fondo y la mantiene en loop
        /// </summary>
        public void SonidoAmbiente()
        {
            sonidoEntradaCarga = new SoundPlayer($"{Environment.CurrentDirectory}\\csSound.wav");
            sonidoEntradaCarga.PlayLooping();
        }

        
    }
}
