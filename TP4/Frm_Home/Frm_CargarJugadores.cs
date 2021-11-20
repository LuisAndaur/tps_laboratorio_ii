using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Entidades_TorneoPRO;

namespace Frm_TorneoPRO
{
    public partial class Frm_CargarJugadores : Form
    {
        private CancellationTokenSource tokenSource;

        public Frm_CargarJugadores()
        {
            InitializeComponent();
        }

        private void Frm_CargarJugadores_Load(object sender, EventArgs e)
        {
            ConexionDB.EventoActualizar += this.ActualizarProgressBar;            
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.tokenSource = TorneoPro.Token;
            this.tokenSource.Cancel();
            this.Close();
        }

        private void btn_Continuar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarProgressBar(int valor)
        {
            if (this.prb_Progreso.InvokeRequired)
            {
                DelegadoActualizar del = new DelegadoActualizar(this.ActualizarProgressBar);
                object[] arg = new object[] { valor};
                this.prb_Progreso.Invoke(del, arg);
            }
            else
            {
                this.prb_Progreso.Minimum = 0;
                this.prb_Progreso.Maximum = ConexionDB.totalColumnas;
                this.prb_Progreso.Value = valor;
                this.lbl_JugadoresCargados.Text = valor.ToString();
                lbl_CantidadTotal.Text = ConexionDB.totalColumnas.ToString();

            }
        }

        private void Frm_CargarJugadores_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConexionDB.EventoActualizar -= this.ActualizarProgressBar;
        }
    }
}
