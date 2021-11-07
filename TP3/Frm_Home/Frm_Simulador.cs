using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_TorneoPRO
{
    public partial class Frm_Simulador : Form
    {
        /// <summary>
        /// Constructor que inicializa los componentes
        /// </summary>
        public Frm_Simulador()
        {
            InitializeComponent();
            tmr_Simulacion.Enabled = true;
            pbr_Simulador.Value = 0;
        }

        /// <summary>
        /// Evento Tick del timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmr_Simulacion_Tick(object sender, EventArgs e)
        {
            this.pbr_Simulador.Increment(10);

            if (pbr_Simulador.Value == 100)
            {
                tmr_Simulacion.Enabled = false;
                this.Close();
                Frm_Mensaje mensaje = new Frm_Mensaje("Torneo simulado\nEXITOSAMENTE!");
                mensaje.ShowDialog();
            }
        }
        
    }
}
