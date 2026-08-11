using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PracticaFinalProgramacionBasica
{
    public partial class frmListarPacientes : Form
    {
        private GestorPacientes gestor;

        public frmListarPacientes(GestorPacientes gestorCompartido)
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
