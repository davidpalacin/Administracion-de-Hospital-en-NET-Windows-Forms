namespace HospitalForm
{
    partial class FormCrearMedico
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDNIMedico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreMedico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(244, 211);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(186, 54);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAceptar.Location = new System.Drawing.Point(12, 211);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(186, 54);
            this.btnAceptar.TabIndex = 25;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Items.AddRange(new object[] {
            "Pediatra",
            "Traumatologo",
            "Cardiologo",
            "Oftalmologo",
            "Odontologo",
            "Psiquiatra",
            "Dermatologo",
            "Ginecologo",
            "Urologo",
            "Endocrinologo",
            "Otorrinolaringologo"});
            this.cmbEspecialidad.Location = new System.Drawing.Point(509, 103);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(186, 28);
            this.cmbEspecialidad.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Especialidad";
            // 
            // txtDNIMedico
            // 
            this.txtDNIMedico.Location = new System.Drawing.Point(259, 106);
            this.txtDNIMedico.Name = "txtDNIMedico";
            this.txtDNIMedico.Size = new System.Drawing.Size(207, 26);
            this.txtDNIMedico.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "DNI";
            // 
            // txtNombreMedico
            // 
            this.txtNombreMedico.Location = new System.Drawing.Point(15, 106);
            this.txtNombreMedico.Name = "txtNombreMedico";
            this.txtNombreMedico.Size = new System.Drawing.Size(207, 26);
            this.txtNombreMedico.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Creación Médico";
            // 
            // FormCrearMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 398);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDNIMedico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreMedico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCrearMedico";
            this.Text = "FormCrearMedico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDNIMedico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreMedico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}