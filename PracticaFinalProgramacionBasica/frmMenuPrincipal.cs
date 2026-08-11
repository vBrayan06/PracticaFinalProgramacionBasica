using System;
using System.Windows.Forms;

namespace PracticaFinalProgramacionBasica
{
    public partial class frmMenuPrincipal : Form
    {
        private GestorPacientes gestorCompartido = new GestorPacientes();

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            frmRegistrarPaciente ventanaRegistro = new frmRegistrarPaciente(gestorCompartido);
            ventanaRegistro.ShowDialog();
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            frmBuscarPacientes ventanaConsultar = new frmBuscarPacientes(gestorCompartido);
            ventanaConsultar.ShowDialog();
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnListarPacientes_Click(object sender, EventArgs e)
        {
            frmListarPacientes ventanaConsultar = new frmListarPacientes(gestorCompartido);
            ventanaConsultar.ShowDialog();
        }
    }
}