namespace PracticaFinalProgramacionBasica
{
    partial class frmConsultarPacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblConsultaDePacientes = new Label();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnMostrarTodos = new Button();
            dgvPacientes = new DataGridView();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // lblConsultaDePacientes
            // 
            lblConsultaDePacientes.AutoSize = true;
            lblConsultaDePacientes.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsultaDePacientes.Location = new Point(344, 29);
            lblConsultaDePacientes.Name = "lblConsultaDePacientes";
            lblConsultaDePacientes.Size = new Size(296, 37);
            lblConsultaDePacientes.TabIndex = 1;
            lblConsultaDePacientes.Text = "Consulta de Pacientes";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscar.Location = new Point(197, 128);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(286, 30);
            lblBuscar.TabIndex = 2;
            lblBuscar.Text = "Buscar por Cédula o Nombre:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(197, 168);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(286, 23);
            txtBuscar.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(489, 166);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(133, 27);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnMostrarTodos
            // 
            btnMostrarTodos.Location = new Point(628, 166);
            btnMostrarTodos.Name = "btnMostrarTodos";
            btnMostrarTodos.Size = new Size(160, 27);
            btnMostrarTodos.TabIndex = 5;
            btnMostrarTodos.Text = "Mostrar Todos";
            btnMostrarTodos.UseVisualStyleBackColor = true;
            // 
            // dgvPacientes
            // 
            dgvPacientes.BackgroundColor = Color.White;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(99, 244);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.Size = new Size(786, 150);
            dgvPacientes.TabIndex = 6;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnVolver.Location = new Point(391, 474);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(203, 44);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Volver al menú";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // frmConsultarPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(984, 561);
            Controls.Add(btnVolver);
            Controls.Add(dgvPacientes);
            Controls.Add(btnMostrarTodos);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(lblConsultaDePacientes);
            Name = "frmConsultarPacientes";
            Text = "Consulta de Pacientes";
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConsultaDePacientes;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnMostrarTodos;
        private DataGridView dgvPacientes;
        private Button btnVolver;
    }
}