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
    public partial class Frm_ModalABM : Form
    {
        Jugador auxJugador = new Jugador(); 
        string tipo = string.Empty;

        public Frm_ModalABM()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Precarga elementos antes de abrir el form depende el tipo necesario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_ModalABM_Load(object sender, EventArgs e)
        {
            if (tipo == "agregar")
            {
                lbl_Titulo.Text = "Menu agregar jugador";
                btn_Editar.Visible = false;
                txt_NroJugador.ReadOnly = false;
            }
            else
            {
                lbl_Titulo.Text = "Menu editar jugador";
                btn_Agregar.Enabled = false;                
                txt_NroJugador.Text = auxJugador.NroJugador.ToString();
                txt_Nombre.Text = auxJugador.Nombre;
                cmb_Genero.Text = auxJugador.Genero;
                txt_Edad.Text = auxJugador.Edad.ToString();
                txt_Nacionalidad.Text = auxJugador.Nacionalidad;
                cmb_Especialidad.Text = auxJugador.Especialidad;
                ckb_PrimerTorneo.Checked = auxJugador.PrimerTorneo;
            }
        }

        /// <summary>
        /// Constructor del form modal
        /// </summary>
        /// <param name="tipo">Tipo de accion</param>
        public Frm_ModalABM(string tipo) : this()
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Constructor del form modal
        /// </summary>
        /// <param name="tipo">Tipo de accion</param>
        /// <param name="jugador">Un jugador seleccionado</param>
        public Frm_ModalABM(string tipo, Jugador jugador) : this()
        {
            this.tipo = tipo;
            this.auxJugador = jugador;            
        }

        /// <summary>
        /// Se agrega un nuevo jugador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception_NroJugadorYaExiste">Error si el numero ya existe</exception>
        /// <exception cref="Exception_EdadInvalida">Error si la edad esta fuera de rango</exception>
        /// <exception cref="Exception_StringNullOrEmpty">Error si hay un string vacio o null</exception>
        /// <exception cref="Exception_GeneroInvalido">Error si ingresa un genero invalido</exception>
        /// <exception cref="Exception_EspecialidadFueraDeRango">Error si se ingresa una especialidad invalida</exception>
        /// <exception cref="Exception_ErrorAgregarJugador">Error si no se puedo agregar el jugador</exception>
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_NroJugador.Text) && !string.IsNullOrEmpty(txt_Nombre.Text) && !string.IsNullOrEmpty(txt_Nacionalidad.Text) && !string.IsNullOrEmpty(cmb_Genero.Text) && !string.IsNullOrEmpty(cmb_Especialidad.Text) && !string.IsNullOrEmpty(txt_Edad.Text))
                {
                    if (DialogResult != DialogResult.OK)
                    {
                        TorneoPro.AgregarJugador(txt_NroJugador.Text, txt_Nombre.Text, txt_Edad.Text, cmb_Genero.Text, txt_Nacionalidad.Text, cmb_Especialidad.Text, ckb_PrimerTorneo.Checked);
                        this.Close();
                        Frm_Mensaje mensaje = new Frm_Mensaje("Jugador agregado\nEXITOSAMENTE!");
                        mensaje.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception_NroJugadorYaExiste eNroJugador)
            {
                MessageBox.Show(eNroJugador.Message, "Numero de jugador ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception_EdadInvalida eEdad)
            {
                MessageBox.Show(eEdad.Message, "Edad no valida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception_StringNullOrEmpty eString)
            {
                MessageBox.Show(eString.Message, "String empty o null", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception_GeneroInvalido eGenero)
            {
                MessageBox.Show(eGenero.Message, "Genero invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception_EspecialidadFueraDeRango eEspecialidad)
            {
                MessageBox.Show(eEspecialidad.Message, "Especialidad fuera de las permitidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception_ErrorAgregarJugador eAgregar)
            {
                MessageBox.Show(eAgregar.Message, "Error al intentar agregar un jugador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception auxEx)
            {
                MessageBox.Show(auxEx.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Edita el jugador seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception_NroJugadorYaExiste">Error si el numero ya existe</exception>
        /// <exception cref="Exception_EdadInvalida">Error si la edad esta fuera de rango</exception>
        /// <exception cref="Exception_StringNullOrEmpty">Error si hay un string vacio o null</exception>
        /// <exception cref="Exception_GeneroInvalido">Error si ingresa un genero invalido</exception>
        /// <exception cref="Exception_EspecialidadFueraDeRango">Error si se ingresa una especialidad invalida</exception>
        /// <exception cref="Exception_EditarJugador">Error si no se puedo editar el jugador</exception>
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_Nombre.Text) && !string.IsNullOrEmpty(txt_Nacionalidad.Text) && !string.IsNullOrEmpty(cmb_Genero.Text) && !string.IsNullOrEmpty(cmb_Especialidad.Text) && !string.IsNullOrEmpty(txt_Edad.Text))
                {
                    if (DialogResult != DialogResult.OK)
                    {
                        int.TryParse(txt_NroJugador.Text, out int auxNro);
                        int.TryParse(txt_Edad.Text, out int auxEdad);
                        auxJugador.NroJugador = auxNro;
                        auxJugador.Nombre = txt_Nombre.Text;
                        auxJugador.Genero = cmb_Genero.Text;
                        auxJugador.Edad = auxEdad;
                        auxJugador.Nacionalidad = txt_Nacionalidad.Text;
                        auxJugador.Especialidad = cmb_Especialidad.Text;
                        auxJugador.PrimerTorneo = ckb_PrimerTorneo.Checked;

                        TorneoPro.EditarJugador(auxJugador);
                        this.Close();
                        Frm_Mensaje mensaje = new Frm_Mensaje("Jugador editado\nEXITOSAMENTE!");
                        mensaje.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception_EdadInvalida eEdad)
            {
                MessageBox.Show(eEdad.Message, "Edad no valida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception_StringNullOrEmpty eString)
            {
                MessageBox.Show(eString.Message, "String empty o null", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception_GeneroInvalido eGenero)
            {
                MessageBox.Show(eGenero.Message, "Genero invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception_EspecialidadFueraDeRango eEspecialidad)
            {
                MessageBox.Show(eEspecialidad.Message, "Especialidad fuera de las permitidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception_EditarJugador eEditar)
            {
                MessageBox.Show(eEditar.Message, "Error al editar jugador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception auxEx)
            {
                MessageBox.Show(auxEx.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Permite ingresar solo letras
        /// </summary>
        /// <param name="e"></param>
        private void SoloLetras(KeyPressEventArgs e)
        {
            if ((e.KeyChar > 31 && e.KeyChar < 65) || (e.KeyChar > 90 && e.KeyChar < 97) || (e.KeyChar > 122 && e.KeyChar < 256))
            {
                MessageBox.Show("Sólo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite ingresar solo numeros
        /// </summary>
        /// <param name="e"></param>
        private void SoloNumeros(KeyPressEventArgs e)
        {
            if ((e.KeyChar > 31 && e.KeyChar < 48) || (e.KeyChar > 57 && e.KeyChar < 256))
            {
                MessageBox.Show("Sólo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        /// <summary>
        /// Solo permite ingreo de numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_NroJugador_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        /// <summary>
        /// Solo permite ingreso de letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        /// <summary>
        /// Solo permite ingreo de numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        /// <summary>
        /// Solo permite ingreso de letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Nacionalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }
    }
}
