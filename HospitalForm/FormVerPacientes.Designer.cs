namespace HospitalForm
{
    partial class FormVerPacientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pacientes";
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(58, 49);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.RowHeadersWidth = 62;
            this.dgvPacientes.RowTemplate.Height = 28;
            this.dgvPacientes.Size = new System.Drawing.Size(906, 357);
            this.dgvPacientes.TabIndex = 1;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 582);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(166, 55);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormVerPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 649);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.label1);
            this.Name = "FormVerPacientes";
            this.Text = "FormVerPacientes";
            this.Load += new System.EventHandler(this.FormVerPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.Button btnVolver;
    }
}