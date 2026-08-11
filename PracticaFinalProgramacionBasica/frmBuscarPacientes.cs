using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PracticaFinalProgramacionBasica
{
    public partial class frmBuscarPacientes : Form
    {
        private GestorPacientes gestor;

        public frmBuscarPacientes(GestorPacientes gestorCompartido)
        {
            InitializeComponent();
            gestor = gestorCompartido;
            ActualizarGrid(gestor.ObtenerPacientes());
        }

        private void ActualizarGrid(List<Paciente> lista)
        {
            dgvPacientes.DataSource = null;
            dgvPacientes.DataSource = lista;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string termino = txtBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(termino))
            {
                MessageBox.Show("Por favor, ingresa un nombre o cédula para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Paciente pacientePorID = gestor.BuscarPorID(termino);

            if (pacientePorID != null)
            {
                List<Paciente> resultadoID = new List<Paciente>();
                resultadoID.Add(pacientePorID);
                ActualizarGrid(resultadoID);
            }
            else
            {
                List<Paciente> resultadosNombre = gestor.BuscarPorNombre(termino);

                if (resultadosNombre.Count > 0)
                {
                    ActualizarGrid(resultadosNombre);
                }
                else
                {
                    MessageBox.Show("No se encontró ningún paciente con ese nombre o cédula.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrid(new List<Paciente>());
                }
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            ActualizarGrid(gestor.ObtenerPacientes());
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblConsultaDePacientes_Click(object sender, EventArgs e)
        {

        }
    }
}