
namespace Frm_TorneoPRO
{
    partial class Frm_ModalABM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ModalABM));
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.lbl_NroJugador = new System.Windows.Forms.Label();
            this.txt_NroJugador = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.cmb_Genero = new System.Windows.Forms.ComboBox();
            this.lbl_Genero = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_Nacionalidad = new System.Windows.Forms.Label();
            this.txt_Nacionalidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Especialidad = new System.Windows.Forms.ComboBox();
            this.ckb_PrimerTorneo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btn_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_Agregar.FlatAppearance.BorderSize = 2;
            this.btn_Agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_Agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Agregar.Location = new System.Drawing.Point(12, 285);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(340, 62);
            this.btn_Agregar.TabIndex = 6;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btn_Editar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_Editar.FlatAppearance.BorderSize = 2;
            this.btn_Editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_Editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Editar.Location = new System.Drawing.Point(12, 285);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(340, 62);
            this.btn_Editar.TabIndex = 7;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // lbl_NroJugador
            // 
            this.lbl_NroJugador.AutoSize = true;
            this.lbl_NroJugador.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_NroJugador.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_NroJugador.Location = new System.Drawing.Point(152, 27);
            this.lbl_NroJugador.Name = "lbl_NroJugador";
            this.lbl_NroJugador.Size = new System.Drawing.Size(94, 19);
            this.lbl_NroJugador.TabIndex = 8;
            this.lbl_NroJugador.Text = "Nro Jugador";
            // 
            // txt_NroJugador
            // 
            this.txt_NroJugador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txt_NroJugador.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NroJugador.Location = new System.Drawing.Point(252, 22);
            this.txt_NroJugador.Name = "txt_NroJugador";
            this.txt_NroJugador.ReadOnly = true;
            this.txt_NroJugador.Size = new System.Drawing.Size(100, 27);
            this.txt_NroJugador.TabIndex = 9;
            this.txt_NroJugador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NroJugador_KeyPress);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txt_Nombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Nombre.Location = new System.Drawing.Point(83, 67);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(269, 27);
            this.txt_Nombre.TabIndex = 10;
            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Nombre.Location = new System.Drawing.Point(12, 70);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(65, 19);
            this.lbl_Nombre.TabIndex = 11;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Edad.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Edad.Location = new System.Drawing.Point(223, 115);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(42, 19);
            this.lbl_Edad.TabIndex = 13;
            this.lbl_Edad.Text = "Edad";
            // 
            // txt_Edad
            // 
            this.txt_Edad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txt_Edad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Edad.Location = new System.Drawing.Point(279, 112);
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(73, 27);
            this.txt_Edad.TabIndex = 12;
            this.txt_Edad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Edad_KeyPress);
            // 
            // cmb_Genero
            // 
            this.cmb_Genero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cmb_Genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Genero.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Genero.FormattingEnabled = true;
            this.cmb_Genero.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmb_Genero.Location = new System.Drawing.Point(83, 111);
            this.cmb_Genero.Name = "cmb_Genero";
            this.cmb_Genero.Size = new System.Drawing.Size(116, 28);
            this.cmb_Genero.TabIndex = 14;
            // 
            // lbl_Genero
            // 
            this.lbl_Genero.AutoSize = true;
            this.lbl_Genero.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Genero.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Genero.Location = new System.Drawing.Point(12, 115);
            this.lbl_Genero.Name = "lbl_Genero";
            this.lbl_Genero.Size = new System.Drawing.Size(58, 19);
            this.lbl_Genero.TabIndex = 15;
            this.lbl_Genero.Text = "Genero";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Frm_TorneoPRO.Properties.Resources.terro;
            this.pictureBox1.Location = new System.Drawing.Point(368, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lbl_Titulo.Location = new System.Drawing.Point(492, 11);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(198, 21);
            this.lbl_Titulo.TabIndex = 17;
            this.lbl_Titulo.Text = "Agregar o editar jugador";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Frm_TorneoPRO.Properties.Resources.Logo_CSGO;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_Nacionalidad
            // 
            this.lbl_Nacionalidad.AutoSize = true;
            this.lbl_Nacionalidad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nacionalidad.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Nacionalidad.Location = new System.Drawing.Point(12, 160);
            this.lbl_Nacionalidad.Name = "lbl_Nacionalidad";
            this.lbl_Nacionalidad.Size = new System.Drawing.Size(98, 19);
            this.lbl_Nacionalidad.TabIndex = 19;
            this.lbl_Nacionalidad.Text = "Nacionalidad";
            // 
            // txt_Nacionalidad
            // 
            this.txt_Nacionalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txt_Nacionalidad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Nacionalidad.Location = new System.Drawing.Point(116, 155);
            this.txt_Nacionalidad.Name = "txt_Nacionalidad";
            this.txt_Nacionalidad.Size = new System.Drawing.Size(236, 27);
            this.txt_Nacionalidad.TabIndex = 20;
            this.txt_Nacionalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nacionalidad_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Especialidad";
            // 
            // cmb_Especialidad
            // 
            this.cmb_Especialidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cmb_Especialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Especialidad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Especialidad.FormattingEnabled = true;
            this.cmb_Especialidad.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "XXL"});
            this.cmb_Especialidad.Location = new System.Drawing.Point(116, 195);
            this.cmb_Especialidad.Name = "cmb_Especialidad";
            this.cmb_Especialidad.Size = new System.Drawing.Size(83, 28);
            this.cmb_Especialidad.TabIndex = 21;
            // 
            // ckb_PrimerTorneo
            // 
            this.ckb_PrimerTorneo.AutoSize = true;
            this.ckb_PrimerTorneo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckb_PrimerTorneo.ForeColor = System.Drawing.SystemColors.Control;
            this.ckb_PrimerTorneo.Location = new System.Drawing.Point(231, 201);
            this.ckb_PrimerTorneo.Name = "ckb_PrimerTorneo";
            this.ckb_PrimerTorneo.Size = new System.Drawing.Size(121, 24);
            this.ckb_PrimerTorneo.TabIndex = 23;
            this.ckb_PrimerTorneo.Text = "Primer Torneo";
            this.ckb_PrimerTorneo.UseVisualStyleBackColor = true;
            // 
            // Frm_ModalABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(80)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(707, 384);
            this.Controls.Add(this.ckb_PrimerTorneo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Especialidad);
            this.Controls.Add(this.txt_Nacionalidad);
            this.Controls.Add(this.lbl_Nacionalidad);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Genero);
            this.Controls.Add(this.cmb_Genero);
            this.Controls.Add(this.lbl_Edad);
            this.Controls.Add(this.txt_Edad);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_NroJugador);
            this.Controls.Add(this.lbl_NroJugador);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ModalABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar jugador";
            this.Load += new System.EventHandler(this.Frm_ModalABM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Label lbl_NroJugador;
        private System.Windows.Forms.TextBox txt_NroJugador;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Edad;
        private System.Windows.Forms.TextBox txt_Edad;
        private System.Windows.Forms.ComboBox cmb_Genero;
        private System.Windows.Forms.Label lbl_Genero;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_Nacionalidad;
        private System.Windows.Forms.TextBox txt_Nacionalidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Especialidad;
        private System.Windows.Forms.CheckBox ckb_PrimerTorneo;
    }
}