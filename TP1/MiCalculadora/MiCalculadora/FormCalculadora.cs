using System;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        /// <summary>
        /// Inicializa los componentes
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();            
        }

        /// <summary>
        /// Ocurre antes de que se muestre el formulario por primera vez.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Intenta cerrar la aplicación si el usuario hace clic en Sí.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Convierte un número doble en un número de formato binario y lo muestra en la pantalla de la aplicación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando aBinario = new Operando();
            lstOperaciones.Items.Add($"{lblResultado.Text} = {aBinario.DecimalBinario(lblResultado.Text)}");
            lblResultado.Text = aBinario.DecimalBinario(lblResultado.Text);
        }

        /// <summary>
        /// Convierte una cadena de formato binario en un número doble y lo muestra en la pantalla de la aplicación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando aDecimal = new Operando();
            lstOperaciones.Items.Add($"{lblResultado.Text} = {aDecimal.BinarioDecimal(lblResultado.Text)}");
            lblResultado.Text = aDecimal.BinarioDecimal(lblResultado.Text);
        }

        /// <summary>
        /// Limpia todos los campos de la aplicación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Ejecuta el cálculo matemático requerido una vez llenado todos los campos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text != "" && txtNumero2.Text != "" && !cmbOperador.SelectedIndex.Equals(-1))
            {
                this.lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
                this.lstOperaciones.Items.AddRange(new object[] { $"{txtNumero1.Text} {cmbOperador.Text} {txtNumero2.Text} = {lblResultado.Text}" });
                if (lblResultado.Text == double.MinValue.ToString())
                {
                    MessageBox.Show("ATENCIÓN!\n No se divide por 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ATENCIÓN!\n Debe completar todos los campos para operar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }        

        /// <summary>
        /// Limpia todos los campos de la aplicaión.
        /// </summary>
        private void Limpiar()
        {
            this.lblResultado.Text = "0";
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.lstOperaciones.Items.Clear();
            this.cmbOperador.Items.Clear();
            this.cmbOperador.Items.AddRange(new object[] {
            "",
            "+",
            "-",
            "*",
            "/"});
        }

        /// <summary>
        /// Recibe dos números válidos y un operador con formato string para operar entre ellos.
        /// </summary>
        /// <param name="numero1">Primer numero en formato string para operar</param>
        /// <param name="numero2">Segundo numero en formato string para operar</param>
        /// <param name="operador">Operador en formato string para operar</param>
        /// <returns>El resultado de la operacion entre los dos numeros</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {            
            Operando auxNumero1 = new Operando(numero1);
            Operando auxNumero2 = new Operando(numero2);
            char.TryParse(operador, out char auxOperador);

            return Calculadora.Operar(auxNumero1, auxNumero2, auxOperador);
        }

        /// <summary>
        /// Intenta cerrar la aplicación si el usuario hace clic en Sí.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }
    }
}
