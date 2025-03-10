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
    public partial class FormVerPacientes: Form
    {
        public List<Paciente> ListPacientes { get; set; }
        public FormVerPacientes(List<Paciente> listPacientes)
        {
            InitializeComponent();
            ListPacientes = listPacientes;
        }

        private void FormVerPacientes_Load(object sender, EventArgs e)
        {
            // Cargar los pacientes en el DataGridView
            dgvPacientes.DataSource = ListPacientes;

            // ordenar
            dgvPacientes.Columns["Nombre"].DisplayIndex = 0;
            dgvPacientes.Columns["DNI"].DisplayIndex = 1;
            dgvPacientes.Columns["MedicoCabecera"].DisplayIndex = 2;
            dgvPacientes.Columns["TipoEnfermedad"].DisplayIndex = 3;
            dgvPacientes.Columns["Curado"].DisplayIndex = 4;

            // Titulos en negrita
            dgvPacientes.Columns["Nombre"].HeaderCell.Style.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvPacientes.Columns["DNI"].HeaderCell.Style.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvPacientes.Columns["MedicoCabecera"].HeaderCell.Style.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvPacientes.Columns["TipoEnfermedad"].HeaderCell.Style.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvPacientes.Columns["Curado"].HeaderCell.Style.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
