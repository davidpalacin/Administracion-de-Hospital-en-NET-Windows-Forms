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

            // Ajustar tamaño de las columnas
            dgvMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Ajustar el tamaño del DataGridView al contenido
            dgvMedicos.Size = new Size(
                dgvMedicos.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + dgvMedicos.RowHeadersWidth,
                dgvMedicos.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + dgvMedicos.ColumnHeadersHeight
            );

            // Limitar el tamaño máximo del DataGridView
            dgvMedicos.MaximumSize = new Size(this.ClientSize.Width, this.ClientSize.Height);

            // Permitir editar las celdas
            dgvMedicos.ReadOnly = false;

            // Permitir agregar nuevas filas
            dgvMedicos.AllowUserToAddRows = true;


            // Permitir eliminar filas
            dgvMedicos.AllowUserToDeleteRows = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMedicos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var filaEditada = dgvMedicos.Rows[e.RowIndex];
            var medicoEditado = (Medico)filaEditada.DataBoundItem;

            if (medicoEditado != null)
            {
                medicoEditado.Nombre = filaEditada.Cells["Nombre"].Value.ToString();
                medicoEditado.DNI = filaEditada.Cells["DNI"].Value.ToString();
                medicoEditado.Especialidad = (Especialidad)Enum.Parse(typeof(Especialidad), filaEditada.Cells["Especialidad"].Value.ToString());
            }
        }

        private void dgvMedicos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Mostrar un mensaje de error o simplemente ignorar el error
            MessageBox.Show("Error en la celda: " + e.Context.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.ThrowException = false; // Evitar que se lance la excepción
        }

        private void EliminarFilaSeleccionada()
        {
            if (dgvMedicos.SelectedRows.Count > 0) // Verifica si hay una fila seleccionada
            {
                DialogResult confirmacion = MessageBox.Show(
                    "¿Seguro que deseas eliminar este médico?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvMedicos.SelectedRows)
                    {
                        Medico medicoAEliminar = (Medico)row.DataBoundItem;
                        if (medicoAEliminar != null)
                        {
                            Medicos.Remove(medicoAEliminar); // Eliminar de la lista
                        }
                    }

                    // Refrescar el DataGridView para mostrar los cambios
                    dgvMedicos.DataSource = null;
                    dgvMedicos.DataSource = Medicos;
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EliminarFilaSeleccionada();
        }
    }
}
