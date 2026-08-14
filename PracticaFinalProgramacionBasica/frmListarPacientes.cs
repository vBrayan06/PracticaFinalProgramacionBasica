using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PracticaFinalProgramacionBasica
{
    public partial class frmListarPacientes : Form
    {
        // Usamos el mismo gestor compartido para acceder
        // a los pacientes que ya están registrados.
        private GestorPacientes gestor;

        public frmListarPacientes(GestorPacientes gestorCompartido)
        {
            InitializeComponent();
            gestor = gestorCompartido;

            // Apenas se abre este formulario mostramos la lista completa.
            ActualizarGrid(gestor.ObtenerPacientes());
        }

        // Actualizamos los datos que aparecen en la tabla.
        private void ActualizarGrid(List<Paciente> lista)
        {
            dgvPacientes.DataSource = null;
            dgvPacientes.DataSource = lista;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Antes de regresar al menú preguntamos si se quiere
            // volver a mostrar la lista de pacientes.
            DialogResult respuesta = MessageBox.Show(
                "¿Deseas listar nuevamente los pacientes?",
                "Continuar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                ActualizarGrid(gestor.ObtenerPacientes());
            }
            else
            {
                this.Close();
            }
        }
    }
}