using System;
using System.Windows.Forms;

namespace PracticaFinalProgramacionBasica
{
    public partial class frmRegistrarPaciente : Form
    {
        private GestorPacientes gestor;

        public frmRegistrarPaciente(GestorPacientes gestorCompartido)
        {
            InitializeComponent();
            gestor = gestorCompartido;
        }

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

     
        private void txtCedula_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtDiagnostico_TextChanged(object sender, EventArgs e) { }
        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dtpFechaIngreso_ValueChanged(object sender, EventArgs e) { }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text) ||
                string.IsNullOrWhiteSpace(txtNombreCompleto.Text) ||
                string.IsNullOrWhiteSpace(txtEdad.Text) ||
                string.IsNullOrWhiteSpace(txtDiagnostico.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtEdad.Text, out int edad) || edad <= 0)
            {
                MessageBox.Show("Por favor, introduce una edad válida en números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

            bool registradoExitosamente = gestor.RegistrarPaciente(nuevoPaciente);

            if (registradoExitosamente)
            {
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
                MessageBox.Show("Ya existe un paciente registrado con esta Cédula.", "Error de Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}