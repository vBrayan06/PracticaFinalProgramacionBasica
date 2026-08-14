using System;
using System.Windows.Forms;

namespace PracticaFinalProgramacionBasica
{
    public partial class frmEliminarPaciente : Form
    {
        // Usamos el gestor compartido para buscar y eliminar
        // dentro de la misma lista de pacientes.
        private GestorPacientes gestor;

        public frmEliminarPaciente(GestorPacientes gestorCompartido)
        {
            InitializeComponent();
            gestor = gestorCompartido;

            // El botón empieza deshabilitado porque primero
            // hay que encontrar al paciente.
            btnEliminar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("Por favor, ingresa la Cédula para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Buscamos el paciente por la cédula escrita.
                Paciente pacienteEncontrado = gestor.BuscarPorID(txtCedula.Text.Trim());

                if (pacienteEncontrado != null)
                {
                    // Mostramos algunos datos para que el usuario pueda
                    // comprobar que encontró a la persona correcta.
                    lblNombreInfo.Text = pacienteEncontrado.Nombre_Completo;
                    lblEdadInfo.Text = pacienteEncontrado.Edad.ToString();
                    lblSexoInfo.Text = pacienteEncontrado.Sexo.ToString();
                    lblDiagnosticoInfo.Text = pacienteEncontrado.Diagnostico;
                    lblEstadoInfo.Text = pacienteEncontrado.Estado.ToString();

                    lblNombreInfo.Visible = true;
                    lblEdadInfo.Visible = true;
                    lblSexoInfo.Visible = true;
                    lblDiagnosticoInfo.Visible = true;
                    lblEstadoInfo.Visible = true;

                    // Bloqueamos la cédula y habilitamos Eliminar
                    // solamente después de encontrar un paciente.
                    txtCedula.ReadOnly = true;
                    btnEliminar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se encontró ningún paciente con esa Cédula.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("Por favor, ingresa la Cédula del paciente que deseas eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Volvemos a buscar al paciente antes de eliminar
                // para estar seguros de que todavía existe.
                Paciente pacienteAEliminar = gestor.BuscarPorID(txtCedula.Text.Trim());

                if (pacienteAEliminar == null)
                {
                    MessageBox.Show("No se encontró ningún paciente con esa Cédula para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Antes de borrar definitivamente pedimos una confirmación.
                DialogResult confirmacion = MessageBox.Show(
                    $"¿Estás TOTALMENTE SEGURO de que deseas eliminar al paciente {pacienteAEliminar.Nombre_Completo} del sistema?\n\nEsta acción no se puede deshacer.",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacion == DialogResult.Yes)
                {
                    bool exito = gestor.EliminarPaciente(txtCedula.Text.Trim());

                    if (exito)
                    {
                        // Después de eliminar preguntamos si quiere repetir la operación.
                        DialogResult respuesta = MessageBox.Show(
                            "¡El paciente fue eliminado exitosamente!\n\n¿Deseas eliminar a otro paciente?",
                            "Éxito",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                        if (respuesta == DialogResult.Yes)
                        {
                            LimpiarDatos();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error y no se pudo eliminar el paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Si decide no eliminar, limpiamos todo y puede buscar otra persona.
                    LimpiarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Limpia la información mostrada y deja nuevamente
        // el formulario listo para buscar otra cédula.
        private void LimpiarDatos()
        {
            txtCedula.ReadOnly = false;
            txtCedula.Clear();

            lblNombreInfo.Text = "";
            lblEdadInfo.Text = "";
            lblSexoInfo.Text = "";
            lblDiagnosticoInfo.Text = "";
            lblEstadoInfo.Text = "";

            lblNombreInfo.Visible = false;
            lblEdadInfo.Visible = false;
            lblSexoInfo.Visible = false;
            lblDiagnosticoInfo.Visible = false;
            lblEstadoInfo.Visible = false;

            btnEliminar.Enabled = false;

            txtCedula.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}