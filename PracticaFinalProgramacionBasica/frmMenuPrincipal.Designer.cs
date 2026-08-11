namespace PracticaFinalProgramacionBasica
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            btnRegistrarPaciente = new Button();
            btnBuscarPaciente = new Button();
            btnEliminarPaciente = new Button();
            btnListarPacientes = new Button();
            btnActualizarPaciente = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(129, 35);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(427, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema de gestión de Pacientes";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitulo.Location = new Point(210, 72);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(264, 30);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Hospital Dr. Antonio Musa";
            // 
            // btnRegistrarPaciente
            // 
            btnRegistrarPaciente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnRegistrarPaciente.Location = new Point(95, 207);
            btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            btnRegistrarPaciente.Size = new Size(203, 44);
            btnRegistrarPaciente.TabIndex = 2;
            btnRegistrarPaciente.Text = "Registrar paciente";
            btnRegistrarPaciente.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPaciente
            // 
            btnBuscarPaciente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnBuscarPaciente.Location = new Point(95, 279);
            btnBuscarPaciente.Name = "btnBuscarPaciente";
            btnBuscarPaciente.Size = new Size(203, 44);
            btnBuscarPaciente.TabIndex = 3;
            btnBuscarPaciente.Text = "Buscar paciente";
            btnBuscarPaciente.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPaciente
            // 
            btnEliminarPaciente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnEliminarPaciente.Location = new Point(95, 342);
            btnEliminarPaciente.Name = "btnEliminarPaciente";
            btnEliminarPaciente.Size = new Size(203, 44);
            btnEliminarPaciente.TabIndex = 4;
            btnEliminarPaciente.Text = "Eliminar paciente";
            btnEliminarPaciente.UseVisualStyleBackColor = true;
            // 
            // btnListarPacientes
            // 
            btnListarPacientes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnListarPacientes.Location = new Point(386, 207);
            btnListarPacientes.Name = "btnListarPacientes";
            btnListarPacientes.Size = new Size(203, 44);
            btnListarPacientes.TabIndex = 5;
            btnListarPacientes.Text = "Listar pacientes";
            btnListarPacientes.UseVisualStyleBackColor = true;
            // 
            // btnActualizarPaciente
            // 
            btnActualizarPaciente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnActualizarPaciente.Location = new Point(386, 279);
            btnActualizarPaciente.Name = "btnActualizarPaciente";
            btnActualizarPaciente.Size = new Size(203, 44);
            btnActualizarPaciente.TabIndex = 6;
            btnActualizarPaciente.Text = "Actualizar paciente";
            btnActualizarPaciente.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSalir.Location = new Point(386, 342);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(203, 44);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(684, 461);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizarPaciente);
            Controls.Add(btnListarPacientes);
            Controls.Add(btnEliminarPaciente);
            Controls.Add(btnBuscarPaciente);
            Controls.Add(btnRegistrarPaciente);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Name = "frmMenuPrincipal";
            Text = "Menu principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Button btnRegistrarPaciente;
        private Button btnBuscarPaciente;
        private Button btnEliminarPaciente;
        private Button btnListarPacientes;
        private Button btnActualizarPaciente;
        private Button btnSalir;
    }
}
