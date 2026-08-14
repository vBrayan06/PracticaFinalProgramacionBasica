namespace PracticaFinalProgramacionBasica
{
    partial class frmActualizarPaciente
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
            lblActualizarPaciente = new Label();
            btnVolver = new Button();
            btnActualizar = new Button();
            dtpFechaIngreso = new DateTimePicker();
            lblFechaIngreso = new Label();
            cmbEstado = new ComboBox();
            lblEstado = new Label();
            txtDiagnostico = new TextBox();
            lblDiagnostico = new Label();
            cmbSexo = new ComboBox();
            lblSexo = new Label();
            txtEdad = new TextBox();
            lblEdad = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtCedula = new TextBox();
            lblCedula = new Label();
            btnBuscar = new Button();
            lblLinea = new Label();
            SuspendLayout();
            // 
            // lblActualizarPaciente
            // 
            lblActualizarPaciente.AutoSize = true;
            lblActualizarPaciente.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActualizarPaciente.Location = new Point(186, 22);
            lblActualizarPaciente.Name = "lblActualizarPaciente";
            lblActualizarPaciente.Size = new Size(262, 37);
            lblActualizarPaciente.TabIndex = 2;
            lblActualizarPaciente.Text = "Actualizar Paciente";
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnVolver.Location = new Point(335, 644);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(203, 44);
            btnVolver.TabIndex = 34;
            btnVolver.Text = "Volver al Menú";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnActualizar.Location = new Point(103, 644);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(203, 44);
            btnActualizar.TabIndex = 32;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Location = new Point(268, 581);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(254, 23);
            dtpFechaIngreso.TabIndex = 31;
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaIngreso.Location = new Point(103, 579);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(159, 25);
            lblFechaIngreso.TabIndex = 30;
            lblFechaIngreso.Text = "Fecha de ingreso:";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Ingresado", "", "En Observación", "", "De Alta", "", "Hospitalizado" });
            cmbEstado.Location = new Point(284, 524);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(254, 23);
            cmbEstado.TabIndex = 29;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(103, 519);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(180, 25);
            lblEstado.TabIndex = 28;
            lblEstado.Text = "Estado del paciente:";
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(284, 390);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(254, 107);
            txtDiagnostico.TabIndex = 27;
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiagnostico.Location = new Point(103, 385);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(116, 25);
            lblDiagnostico.TabIndex = 26;
            lblDiagnostico.Text = "Diagnóstico:";
            // 
            // cmbSexo
            // 
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cmbSexo.Location = new Point(284, 338);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(254, 23);
            cmbSexo.TabIndex = 25;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSexo.Location = new Point(103, 336);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(56, 25);
            lblSexo.TabIndex = 24;
            lblSexo.Text = "Sexo:";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(284, 289);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(254, 23);
            txtEdad.TabIndex = 23;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEdad.Location = new Point(103, 287);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(58, 25);
            lblEdad.TabIndex = 22;
            lblEdad.Text = "Edad:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(284, 243);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(254, 23);
            txtNombre.TabIndex = 21;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(103, 238);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(172, 25);
            lblNombre.TabIndex = 20;
            lblNombre.Text = "Nombre Completo:";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(284, 120);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(155, 23);
            txtCedula.TabIndex = 36;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCedula.Location = new Point(103, 119);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(182, 25);
            lblCedula.TabIndex = 35;
            lblCedula.Text = "Cédula del Paciente:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(445, 117);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(93, 28);
            btnBuscar.TabIndex = 37;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblLinea
            // 
            lblLinea.BackColor = SystemColors.ActiveCaptionText;
            lblLinea.BorderStyle = BorderStyle.Fixed3D;
            lblLinea.Location = new Point(17, 186);
            lblLinea.Name = "lblLinea";
            lblLinea.Size = new Size(600, 2);
            lblLinea.TabIndex = 38;
            // 
            // frmActualizarPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(634, 725);
            Controls.Add(lblLinea);
            Controls.Add(btnBuscar);
            Controls.Add(txtCedula);
            Controls.Add(lblCedula);
            Controls.Add(btnVolver);
            Controls.Add(btnActualizar);
            Controls.Add(dtpFechaIngreso);
            Controls.Add(lblFechaIngreso);
            Controls.Add(cmbEstado);
            Controls.Add(lblEstado);
            Controls.Add(txtDiagnostico);
            Controls.Add(lblDiagnostico);
            Controls.Add(cmbSexo);
            Controls.Add(lblSexo);
            Controls.Add(txtEdad);
            Controls.Add(lblEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblActualizarPaciente);
            Name = "frmActualizarPaciente";
            Text = "Actualizar Paciente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblActualizarPaciente;
        private Button btnVolver;
        private Button btnActualizar;
        private DateTimePicker dtpFechaIngreso;
        private Label lblFechaIngreso;
        private ComboBox cmbEstado;
        private Label lblEstado;
        private TextBox txtDiagnostico;
        private Label lblDiagnostico;
        private ComboBox cmbSexo;
        private Label lblSexo;
        private TextBox txtEdad;
        private Label lblEdad;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtCedula;
        private Label lblCedula;
        private Button btnBuscar;
        private Label lblLinea;
    }
}