namespace HospitalForm
{
    partial class Administracion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerPacientes = new System.Windows.Forms.Button();
            this.btnVerDoctores = new System.Windows.Forms.Button();
            this.btnCrearPaciente = new System.Windows.Forms.Button();
            this.btnCrearMedico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administración Hospital";
            // 
            // btnVerPacientes
            // 
            this.btnVerPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPacientes.Location = new System.Drawing.Point(18, 69);
            this.btnVerPacientes.Name = "btnVerPacientes";
            this.btnVerPacientes.Size = new System.Drawing.Size(475, 61);
            this.btnVerPacientes.TabIndex = 1;
            this.btnVerPacientes.Text = "Pacientes";
            this.btnVerPacientes.UseVisualStyleBackColor = true;
            this.btnVerPacientes.Click += new System.EventHandler(this.btnVerPacientes_Click);
            // 
            // btnVerDoctores
            // 
            this.btnVerDoctores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDoctores.Location = new System.Drawing.Point(549, 69);
            this.btnVerDoctores.Name = "btnVerDoctores";
            this.btnVerDoctores.Size = new System.Drawing.Size(475, 61);
            this.btnVerDoctores.TabIndex = 2;
            this.btnVerDoctores.Text = "Doctores";
            this.btnVerDoctores.UseVisualStyleBackColor = true;
            this.btnVerDoctores.Click += new System.EventHandler(this.btnVerDoctores_Click);
            // 
            // btnCrearPaciente
            // 
            this.btnCrearPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPaciente.Location = new System.Drawing.Point(18, 145);
            this.btnCrearPaciente.Name = "btnCrearPaciente";
            this.btnCrearPaciente.Size = new System.Drawing.Size(475, 61);
            this.btnCrearPaciente.TabIndex = 3;
            this.btnCrearPaciente.Text = "Nuevo Paciente";
            this.btnCrearPaciente.UseVisualStyleBackColor = true;
            this.btnCrearPaciente.Click += new System.EventHandler(this.btnCrearPaciente_Click);
            // 
            // btnCrearMedico
            // 
            this.btnCrearMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearMedico.Location = new System.Drawing.Point(549, 145);
            this.btnCrearMedico.Name = "btnCrearMedico";
            this.btnCrearMedico.Size = new System.Drawing.Size(475, 61);
            this.btnCrearMedico.TabIndex = 4;
            this.btnCrearMedico.Text = "Nuevo Doctor";
            this.btnCrearMedico.UseVisualStyleBackColor = true;
            this.btnCrearMedico.Click += new System.EventHandler(this.btnCrearMedico_Click);
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 649);
            this.Controls.Add(this.btnCrearMedico);
            this.Controls.Add(this.btnCrearPaciente);
            this.Controls.Add(this.btnVerDoctores);
            this.Controls.Add(this.btnVerPacientes);
            this.Controls.Add(this.label1);
            this.Name = "Administracion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerPacientes;
        private System.Windows.Forms.Button btnVerDoctores;
        private System.Windows.Forms.Button btnCrearPaciente;
        private System.Windows.Forms.Button btnCrearMedico;
    }
}

