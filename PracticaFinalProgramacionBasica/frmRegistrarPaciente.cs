using System;
using System.Windows.Forms;

namespace PracticaFinalProgramacionBasica
{
    public partial class frmRegistrarPaciente : Form
    {
        // Aquí guardamos el mismo gestor que viene desde el menú principal.
        private GestorPacientes gestor;

        public frmRegistrarPaciente(GestorPacientes gestorCompartido)
        {
            InitializeComponent();
            gestor = gestorCompartido;
        }

        // Cuando abre el formulario cargamos las opciones de los enum
        // dentro de los ComboBox.
        private void frmRegistrarPaciente_Load(object sender, EventArgs e)
        {
            cmbSexo.Items.Clear();
            cmbSexo.Items.Add(Sexo.Masculino);
            cmbSexo.Items.Add(Sexo.Femenino);
            cmbSexo.SelectedIndex = 0;

            cmbEstado.Items.Clear();
            cmbEstado.Items.Add(EstadoPaciente.Ingresado);
            cmbEstado.Items.Add(EstadoPaciente.EnObservacion);
            cmbEstado.Items.Add(EstadoPaciente.DeAlta);
            cmbEstado.Items.Add(EstadoPaciente.Hospitalizado);
            cmbEstado.SelectedIndex = 0;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Primero comprobamos que el usuario haya llenado
            // los campos que son obligatorios.
            if (string.IsNullOrWhiteSpace(txtCedula.Text) ||
                string.IsNullOrWhiteSpace(txtNombreCompleto.Text) ||
                string.IsNullOrWhiteSpace(txtEdad.Text) ||
                string.IsNullOrWhiteSpace(txtDiagnostico.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Intentamos convertir la edad a número.
            // También evitamos que se registren edades de cero o negativas.
            if (!int.TryParse(txtEdad.Text, out int edad) || edad <= 0)
            {
                MessageBox.Show("Por favor, introduce una edad válida en números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Creamos un objeto Paciente con la información
            // que el usuario escribió en los controles del formulario.
            Paciente nuevoPaciente = new Paciente
            {
                Cedula = txtCedula.Text.Trim(),
                Nombre_Completo = txtNombreCompleto.Text.Trim(),
                Edad = edad,
                Sexo = (Sexo)cmbSexo.SelectedItem,
                Diagnostico = txtDiagnostico.Text.Trim(),
                Estado = (EstadoPaciente)cmbEstado.SelectedItem,
                Fecha_De_Ingreso = dtpFechaIngreso.Value
            };

            // Mandamos el objeto al gestor para intentar registrarlo en la lista.
            bool registradoExitosamente = gestor.RegistrarPaciente(nuevoPaciente);

            if (registradoExitosamente)
            {
                // Si se registró correctamente preguntamos si quiere registrar otro.
                DialogResult respuesta = MessageBox.Show(
                    "¡Paciente registrado con éxito!\n\n¿Deseas registrar otro paciente?",
                    "Éxito",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.Yes)
                {
                    btnLimpiar_Click(sender, e);
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                // Si el gestor devuelve false significa que esa cédula ya existe.
                MessageBox.Show("Ya existe un paciente registrado con esta Cédula.", "Error de Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Limpia todos los controles para dejar el formulario listo
        // por si se quiere registrar otro paciente.
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCedula.Clear();
            txtNombreCompleto.Clear();
            txtEdad.Clear();
            txtDiagnostico.Clear();
            cmbSexo.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            dtpFechaIngreso.Value = DateTime.Now;
            txtCedula.Focus();
        }

        // Cerramos solamente este formulario y volvemos al menú.
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}