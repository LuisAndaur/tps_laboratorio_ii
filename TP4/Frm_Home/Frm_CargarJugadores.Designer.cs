
namespace Frm_TorneoPRO
{
    partial class Frm_CargarJugadores
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
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Continuar = new System.Windows.Forms.Button();
            this.prb_Progreso = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_JugadoresCargados = new System.Windows.Forms.Label();
            this.lbl_CantidadTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_Cancelar.FlatAppearance.BorderSize = 2;
            this.btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.Location = new System.Drawing.Point(22, 107);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(97, 35);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Continuar
            // 
            this.btn_Continuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btn_Continuar.Enabled = false;
            this.btn_Continuar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_Continuar.FlatAppearance.BorderSize = 2;
            this.btn_Continuar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_Continuar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btn_Continuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Continuar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Continuar.Location = new System.Drawing.Point(246, 107);
            this.btn_Continuar.Name = "btn_Continuar";
            this.btn_Continuar.Size = new System.Drawing.Size(97, 35);
            this.btn_Continuar.TabIndex = 8;
            this.btn_Continuar.Text = "Continuar";
            this.btn_Continuar.UseVisualStyleBackColor = false;
            this.btn_Continuar.Click += new System.EventHandler(this.btn_Continuar_Click);
            // 
            // prb_Progreso
            // 
            this.prb_Progreso.Location = new System.Drawing.Point(22, 75);
            this.prb_Progreso.Name = "prb_Progreso";
            this.prb_Progreso.Size = new System.Drawing.Size(321, 10);
            this.prb_Progreso.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cargando jugadores";
            // 
            // lbl_JugadoresCargados
            // 
            this.lbl_JugadoresCargados.AutoSize = true;
            this.lbl_JugadoresCargados.Location = new System.Drawing.Point(22, 54);
            this.lbl_JugadoresCargados.Name = "lbl_JugadoresCargados";
            this.lbl_JugadoresCargados.Size = new System.Drawing.Size(13, 15);
            this.lbl_JugadoresCargados.TabIndex = 11;
            this.lbl_JugadoresCargados.Text = "0";
            // 
            // lbl_CantidadTotal
            // 
            this.lbl_CantidadTotal.Location = new System.Drawing.Point(276, 54);
            this.lbl_CantidadTotal.Name = "lbl_CantidadTotal";
            this.lbl_CantidadTotal.Size = new System.Drawing.Size(67, 15);
            this.lbl_CantidadTotal.TabIndex = 12;
            this.lbl_CantidadTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Frm_CargarJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(366, 168);
            this.Controls.Add(this.lbl_CantidadTotal);
            this.Controls.Add(this.lbl_JugadoresCargados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prb_Progreso);
            this.Controls.Add(this.btn_Continuar);
            this.Controls.Add(this.btn_Cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_CargarJugadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_CargarJugadores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_CargarJugadores_FormClosing);
            this.Load += new System.EventHandler(this.Frm_CargarJugadores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Continuar;
        private System.Windows.Forms.ProgressBar prb_Progreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_JugadoresCargados;
        private System.Windows.Forms.Label lbl_CantidadTotal;
    }
}