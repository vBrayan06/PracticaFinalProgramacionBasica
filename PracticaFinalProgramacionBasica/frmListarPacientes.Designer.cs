namespace PracticaFinalProgramacionBasica
{
    partial class frmListarPacientes
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
            btnVolver = new Button();
            dgvPacientes = new DataGridView();
            lblListaDePacientes = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnVolver.Location = new Point(391, 669);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(203, 44);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Volver al menú";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // dgvPacientes
            // 
            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.AllowUserToDeleteRows = false;
            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPacientes.BackgroundColor = Color.White;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(99, 80);
            dgvPacientes.MultiSelect = false;
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.ReadOnly = true;
            dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPacientes.Size = new Size(786, 572);
            dgvPacientes.TabIndex = 9;
            // 
            // lblListaDePacientes
            // 
            lblListaDePacientes.AutoSize = true;
            lblListaDePacientes.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListaDePacientes.Location = new Point(370, 31);
            lblListaDePacientes.Name = "lblListaDePacientes";
            lblListaDePacientes.Size = new Size(244, 37);
            lblListaDePacientes.TabIndex = 8;
            lblListaDePacientes.Text = "Lista de Pacientes";
            // 
            // frmListarPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(984, 734);
            Controls.Add(btnVolver);
            Controls.Add(dgvPacientes);
            Controls.Add(lblListaDePacientes);
            Name = "frmListarPacientes";
            Text = "Lista de Pacientes";
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private DataGridView dgvPacientes;
        private Label lblListaDePacientes;
    }
}