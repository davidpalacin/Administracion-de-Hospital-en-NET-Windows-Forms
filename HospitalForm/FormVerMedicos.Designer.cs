namespace HospitalForm
{
    partial class FormVerMedicos
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
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.Location = new System.Drawing.Point(166, 49);
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.RowHeadersWidth = 62;
            this.dgvMedicos.RowTemplate.Height = 28;
            this.dgvMedicos.Size = new System.Drawing.Size(712, 309);
            this.dgvMedicos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doctores";
            // 
            // FormVerMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 604);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMedicos);
            this.Name = "FormVerMedicos";
            this.Text = "FormVerMedicos";
            this.Load += new System.EventHandler(this.FormVerMedicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.Label label1;
    }
}