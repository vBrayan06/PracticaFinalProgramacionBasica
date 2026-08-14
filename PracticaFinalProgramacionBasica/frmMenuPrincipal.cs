using System;
using System.Windows.Forms;

namespace PracticaFinalProgramacionBasica
{
    public partial class frmMenuPrincipal : Form
    {
        // Creamos un solo gestor para que todos los formularios trabajen
        // con la misma lista de pacientes.
        private GestorPacientes gestorCompartido = new GestorPacientes();

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        // Abre el formulario para registrar pacientes y le pasa el mismo gestor.
        private void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            frmRegistrarPaciente ventanaRegistro = new frmRegistrarPaciente(gestorCompartido);
            ventanaRegistro.ShowDialog();
        }

        // Abre el formulario donde se puede buscar por cédula o nombre.
        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            frmBuscarPacientes ventanaConsultar = new frmBuscarPacientes(gestorCompartido);
            ventanaConsultar.ShowDialog();
        }

        // Abre el formulario que muestra todos los pacientes registrados.
        private void btnListarPacientes_Click(object sender, EventArgs e)
        {
            frmListarPacientes ventanaConsultar = new frmListarPacientes(gestorCompartido);
            ventanaConsultar.ShowDialog();
        }

        // Abre el formulario para buscar un paciente y modificar sus datos.
        private void btnActualizarPaciente_Click(object sender, EventArgs e)
        {
            frmActualizarPaciente ventanaActualizar = new frmActualizarPaciente(gestorCompartido);
            ventanaActualizar.ShowDialog();
        }

        // Esta es la única opción que cierra completamente el programa.
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Abre el formulario para buscar y eliminar un paciente.
        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            frmEliminarPaciente ventanaEliminar = new frmEliminarPaciente(gestorCompartido);
            ventanaEliminar.ShowDialog();
        }
    }
}