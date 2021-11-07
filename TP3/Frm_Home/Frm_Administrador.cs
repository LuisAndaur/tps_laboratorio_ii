using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_TorneoPRO;


namespace Frm_TorneoPRO
{
    public partial class Frm_Administrador : Form
    {
        List<Jugador> listaJugadores = new List<Jugador>();        
        Jugador auxJugador = new Jugador();
        private int indice = 0;

        public Frm_Administrador()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Pre carga del formulario administrador que hace cargar la lista de jugadores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception_SerializacionJson">Error en serializacion o deserializacion de un json</exception>
        private void Frm_Administrador_Load(object sender, EventArgs e)
        {
            try
            {
                listaJugadores = TorneoPro.ListaJugadores;
                RecargarListaJugadores();
            }
            catch (Exception_SerializacionJson eSerializacion)
            {
                MessageBox.Show(eSerializacion.Message, "ERROR al cargar la lista json", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception auxEx)
            {
                MessageBox.Show(auxEx.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// Retorna al form principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Abre el form para agregar un nuevo jugador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Frm_ModalABM agregar = new Frm_ModalABM("agregar");
            agregar.ShowDialog();
            RecargarListaJugadores();
        }

        /// <summary>
        /// Abre el form para editar al jugador seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (auxJugador.NroJugador > 0)
            {
                Frm_ModalABM editar = new Frm_ModalABM("editar", auxJugador);
                editar.ShowDialog();
                RecargarListaJugadores();
            }
            else
            {
                MessageBox.Show("Seleccione el jugador que quiere editar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Elimina al jugador seleccionado en la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception_EliminarJugador">Error si no se puedo eliminar el jugador</exception>
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (auxJugador.NroJugador > 0)
                {
                    TorneoPro.EliminarJugador(auxJugador);
                    Frm_Mensaje mensaje = new Frm_Mensaje("Jugador eliminado\nEXITOSAMENTE!");
                    mensaje.ShowDialog();
                    RecargarListaJugadores();
                }
                else
                {
                    MessageBox.Show("Seleccione el jugador que quiere eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception_EliminarJugador eEliminar)
            {
                MessageBox.Show(eEliminar.Message, "Error al intentar eliminar un jugador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception auxEx)
            {
                MessageBox.Show(auxEx.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Tomas los datos del jugador seleccionado en la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_ListaJugadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            if (indice != -1)
            {
                auxJugador.NroJugador = (int)dgv_ListaJugadores.Rows[indice].Cells[0].Value;
                auxJugador.Nombre = dgv_ListaJugadores.Rows[indice].Cells[1].Value.ToString();
                auxJugador.Edad = (int)dgv_ListaJugadores.Rows[indice].Cells[2].Value;
                auxJugador.Genero = dgv_ListaJugadores.Rows[indice].Cells[3].Value.ToString();
                auxJugador.Nacionalidad = dgv_ListaJugadores.Rows[indice].Cells[4].Value.ToString();
                auxJugador.Especialidad = dgv_ListaJugadores.Rows[indice].Cells[5].Value.ToString();
                auxJugador.PrimerTorneo = (bool)dgv_ListaJugadores.Rows[indice].Cells[6].Value;
            }
        }

        /// <summary>
        /// Carga y refresca la lista de jugadores
        /// </summary>
        private void RecargarListaJugadores()
        {
            dgv_ListaJugadores.Rows.Clear();
            foreach (Jugador item in listaJugadores)
            {
                indice = dgv_ListaJugadores.Rows.Add();
                dgv_ListaJugadores.Rows[indice].Cells[0].Value = item.NroJugador;
                dgv_ListaJugadores.Rows[indice].Cells[1].Value = item.Nombre;
                dgv_ListaJugadores.Rows[indice].Cells[2].Value = item.Edad;
                dgv_ListaJugadores.Rows[indice].Cells[3].Value = item.Genero;
                dgv_ListaJugadores.Rows[indice].Cells[4].Value = item.Nacionalidad;
                dgv_ListaJugadores.Rows[indice].Cells[5].Value = item.Especialidad;
                dgv_ListaJugadores.Rows[indice].Cells[6].Value = item.PrimerTorneo;
            }
        }
    }
}
