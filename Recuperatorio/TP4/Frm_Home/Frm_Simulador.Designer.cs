
namespace Frm_TorneoPRO
{
    partial class Frm_Simulador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbr_Simulador = new System.Windows.Forms.ProgressBar();
            this.tmr_Simulacion = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Frm_TorneoPRO.Properties.Resources.simulador;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(705, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbr_Simulador
            // 
            this.pbr_Simulador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.pbr_Simulador.ForeColor = System.Drawing.Color.Red;
            this.pbr_Simulador.Location = new System.Drawing.Point(-2, 348);
            this.pbr_Simulador.Name = "pbr_Simulador";
            this.pbr_Simulador.Size = new System.Drawing.Size(705, 10);
            this.pbr_Simulador.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbr_Simulador.TabIndex = 1;
            this.pbr_Simulador.Value = 100;
            // 
            // tmr_Simulacion
            // 
            this.tmr_Simulacion.Tick += new System.EventHandler(this.tmr_Simulacion_Tick);
            // 
            // Frm_Simulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(698, 360);
            this.Controls.Add(this.pbr_Simulador);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Simulador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar pbr_Simulador;
        private System.Windows.Forms.Timer tmr_Simulacion;
    }
}