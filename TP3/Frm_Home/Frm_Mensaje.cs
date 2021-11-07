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
    public partial class Frm_Mensaje : Form
    {
        /// <summary>
        /// Constructor del form mensaje
        /// </summary>
        /// <param name="mensaje"></param>
        public Frm_Mensaje(string mensaje)
        {
            InitializeComponent();
            lbl_Mensaje.Text = mensaje;
        }

        /// <summary>
        /// Al dar ok se cierra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
