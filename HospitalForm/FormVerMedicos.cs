using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalForm
{
    public partial class FormVerMedicos: Form
    {
        public List<Medico> Medicos { get; set; }
        public FormVerMedicos(List<Medico> medicos)
        {
            InitializeComponent();
            Medicos = medicos;
        }

        private void FormVerMedicos_Load(object sender, EventArgs e)
        {
            dgvMedicos.DataSource = Medicos;

            // ordenar columnas, primera columna nombre
            dgvMedicos.Columns["Nombre"].DisplayIndex = 0;
            dgvMedicos.Columns["DNI"].DisplayIndex = 1;
            dgvMedicos.Columns["Especialidad"].DisplayIndex = 2;

            // Titulos en negrita
            dgvMedicos.Columns["Nombre"].HeaderCell.Style.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvMedicos.Columns["DNI"].HeaderCell.Style.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvMedicos.Columns["Especialidad"].HeaderCell.Style.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
