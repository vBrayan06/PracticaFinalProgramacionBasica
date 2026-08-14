using System;
using System.Windows.Forms;

namespace PracticaFinalProgramacionBasica
{
    public partial class frmActualizarPaciente : Form
    {
        private GestorPacientes gestor;

        public frmActualizarPaciente(GestorPacientes gestorCompartido)
        {
            InitializeComponent();
            gestor = gestorCompartido;
            CargarOpciones();

            btnActualizar.Enabled = false;
        }

        private void CargarOpciones()
        {
    
            cmbSexo.Items.Clear();
            cmbSexo.Items.Add(Sexo.Masculino);
            cmbSexo.Items.Add(Sexo.Femenino);

            cmbEstado.Items.Clear();
            cmbEstado.Items.Add(EstadoPaciente.Ingresado);
            cmbEstado.Items.Add(EstadoPaciente.EnObservacion);
            cmbEstado.Items.Add(EstadoPaciente.DeAlta);
            cmbEstado.Items.Add(EstadoPaciente.Hospitalizado);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show(
                    "Por favor, ingresa la Cédula para buscar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            btnBuscar.Enabled = false;

            try
            {
                Paciente pacienteEncontrado = gestor.BuscarPorID(txtCedula.Text.Trim());

                if (pacienteEncontrado != null)
                {
                    txtNombre.Text = pacienteEncontrado.Nombre_Completo;
                    txtEdad.Text = pacienteEncontrado.Edad.ToString();
                    cmbSexo.SelectedItem = pacienteEncontrado.Sexo;
                    txtDiagnostico.Text = pacienteEncontrado.Diagnostico;
                    cmbEstado.SelectedItem = pacienteEncontrado.Estado;
                    dtpFechaIngreso.Value = pacienteEncontrado.Fecha_De_Ingreso;

                    txtCedula.ReadOnly = true;
                    btnActualizar.Enabled = true;
                }
                else
                {
                    MessageBox.Show(
                        "No se encontró ningún paciente con esa Cédula.",
                        "Sin resultados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al buscar: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                btnBuscar.Enabled = true;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtEdad.Text) ||
                string.IsNullOrWhiteSpace(txtDiagnostico.Text))
            {
                MessageBox.Show("Por favor, busca un paciente y asegúrate de que los campos no estén vacíos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbSexo.SelectedItem == null || cmbEstado.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona el sexo y el estado del paciente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (!int.TryParse(txtEdad.Text, out int edad) || edad <= 0)
                {
                    MessageBox.Show("Por favor, introduce una edad válida en números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Paciente pacienteActualizado = new Paciente
                {
                    Cedula = txtCedula.Text.Trim(),
                    Nombre_Completo = txtNombre.Text.Trim(),
                    Edad = edad,
                    Sexo = (Sexo)cmbSexo.SelectedItem,
                    Diagnostico = txtDiagnostico.Text.Trim(),
                    Estado = (EstadoPaciente)cmbEstado.SelectedItem,
                    Fecha_De_Ingreso = dtpFechaIngreso.Value
                };

                bool exito = gestor.ActualizarPaciente(pacienteActualizado);

                if (exito)
                {
                  
                    DialogResult respuesta = MessageBox.Show(
                        "¡Los datos del paciente se actualizaron correctamente!\n\n¿Deseas actualizar a otro paciente?",
                        "Éxito",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (respuesta == DialogResult.Yes)
                    {
                        LimpiarCampos();
                    }
                    else
                    {
                        this.Close(); 
                    }
                }
                else
                {
                    MessageBox.Show("Hubo un error al actualizar. Verifica que la Cédula sea correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado al procesar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtCedula.ReadOnly = false;
            txtCedula.Clear();

            txtNombre.Clear();
            txtEdad.Clear();
            txtDiagnostico.Clear();

            cmbSexo.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;

            dtpFechaIngreso.Value = DateTime.Now;

            btnActualizar.Enabled = false;

            txtCedula.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}