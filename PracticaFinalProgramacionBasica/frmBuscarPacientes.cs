using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PracticaFinalProgramacionBasica
{
    public partial class frmBuscarPacientes : Form
    {
        // Recibimos el gestor compartido para buscar en la misma lista
        // donde fueron registrados los pacientes.
        private GestorPacientes gestor;

        public frmBuscarPacientes(GestorPacientes gestorCompartido)
        {
            InitializeComponent();
            gestor = gestorCompartido;

            // Al principio dejamos el DataGridView vacío.
            ActualizarGrid(new List<Paciente>());
        }

        // Este método recibe una lista y la muestra en el DataGridView.
        private void ActualizarGrid(List<Paciente> lista)
        {
            dgvPacientes.DataSource = null;
            dgvPacientes.DataSource = lista;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Guardamos lo que escribió el usuario quitando espacios
            // innecesarios al principio y al final.
            string termino = txtBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(termino))
            {
                MessageBox.Show(
                    "Por favor, ingresa un nombre o cédula para buscar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Primero intentamos buscar por cédula porque la cédula es única.
            Paciente pacientePorID = gestor.BuscarPorID(termino);

            if (pacientePorID != null)
            {
                // Como el DataGridView trabaja con una lista,
                // metemos el paciente encontrado dentro de una lista.
                List<Paciente> resultadoID = new List<Paciente>();
                resultadoID.Add(pacientePorID);

                ActualizarGrid(resultadoID);
            }
            else
            {
                // Si no apareció por cédula, entonces intentamos buscar por nombre.
                // Aquí pueden aparecer varios pacientes.
                List<Paciente> resultadosNombre = gestor.BuscarPorNombre(termino);

                if (resultadosNombre.Count > 0)
                {
                    ActualizarGrid(resultadosNombre);
                }
                else
                {
                    MessageBox.Show(
                        "No se encontró ningún paciente con ese nombre o cédula.",
                        "Sin resultados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    ActualizarGrid(new List<Paciente>());
                }
            }

            PreguntarOtraBusqueda();
        }

        // Después de hacer una búsqueda preguntamos si quiere buscar otra vez
        // o regresar al menú principal.
        private void PreguntarOtraBusqueda()
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Deseas realizar otra búsqueda?",
                "Continuar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                txtBuscar.Clear();
                ActualizarGrid(new List<Paciente>());
                txtBuscar.Focus();
            }
            else
            {
                this.Close();
            }
        }

        // Este botón permite ver toda la lista sin tener que buscar algo específico.
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            ActualizarGrid(gestor.ObtenerPacientes());
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}