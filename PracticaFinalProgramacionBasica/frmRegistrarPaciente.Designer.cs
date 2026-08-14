namespace PracticaFinalProgramacionBasica
{
    partial class frmRegistrarPaciente
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
            lblRegistroPacientes = new Label();
            lblCedula = new Label();
            txtCedula = new TextBox();
            txtNombreCompleto = new TextBox();
            lblNombre = new Label();
            txtEdad = new TextBox();
            lblEdad = new Label();
            lblSexo = new Label();
            cmbSexo = new ComboBox();
            lblDiagnostico = new Label();
            txtDiagnostico = new TextBox();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            lblFechaIngreso = new Label();
            dtpFechaIngreso = new DateTimePicker();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            splitter1 = new Splitter();
            splitter2 = new Splitter();
            SuspendLayout();
            // 
            // lblRegistroPacientes
            // 
            lblRegistroPacientes.AutoSize = true;
            lblRegistroPacientes.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistroPacientes.Location = new Point(171, 20);
            lblRegistroPacientes.Name = "lblRegistroPacientes";
            lblRegistroPacientes.Size = new Size(292, 37);
            lblRegistroPacientes.TabIndex = 1;
            lblRegistroPacientes.Text = "Registro de Pacientes";
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCedula.Location = new Point(103, 86);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(75, 25);
            lblCedula.TabIndex = 2;
            lblCedula.Text = "Cédula:";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(284, 91);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(254, 23);
            txtCedula.TabIndex = 3;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(284, 140);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(254, 23);
            txtNombreCompleto.TabIndex = 5;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(103, 135);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(172, 25);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre Completo:";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(284, 186);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(254, 23);
            txtEdad.TabIndex = 7;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEdad.Location = new Point(103, 184);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(58, 25);
            lblEdad.TabIndex = 6;
            lblEdad.Text = "Edad:";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSexo.Location = new Point(103, 233);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(56, 25);
            lblSexo.TabIndex = 8;
            lblSexo.Text = "Sexo:";
            // 
            // cmbSexo
            // 
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cmbSexo.Location = new Point(284, 235);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(254, 23);
            cmbSexo.TabIndex = 9;
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiagnostico.Location = new Point(103, 282);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(116, 25);
            lblDiagnostico.TabIndex = 10;
            lblDiagnostico.Text = "Diagnóstico:";
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(284, 287);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(254, 107);
            txtDiagnostico.TabIndex = 11;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(103, 416);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(180, 25);
            lblEstado.TabIndex = 12;
            lblEstado.Text = "Estado del paciente:";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Ingresado", "", "En Observación", "", "De Alta", "", "Hospitalizado" });
            cmbEstado.Location = new Point(284, 421);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(254, 23);
            cmbEstado.TabIndex = 13;
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaIngreso.Location = new Point(103, 476);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(159, 25);
            lblFechaIngreso.TabIndex = 14;
            lblFechaIngreso.Text = "Fecha de ingreso:";
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Location = new Point(284, 478);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(254, 23);
            dtpFechaIngreso.TabIndex = 16;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnRegistrar.Location = new Point(7, 541);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(203, 44);
            btnRegistrar.TabIndex = 17;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnLimpiar.Location = new Point(216, 541);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(203, 44);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnVolver.Location = new Point(425, 541);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(203, 44);
            btnVolver.TabIndex = 19;
            btnVolver.Text = "Volver al Menú";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 611);
            splitter1.TabIndex = 20;
            splitter1.TabStop = false;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(3, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(3, 611);
            splitter2.TabIndex = 21;
            splitter2.TabStop = false;
            // 
            // frmRegistrarPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(634, 611);
            Controls.Add(splitter2);
            Controls.Add(splitter1);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
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
            Controls.Add(txtNombreCompleto);
            Controls.Add(lblNombre);
            Controls.Add(txtCedula);
            Controls.Add(lblCedula);
            Controls.Add(lblRegistroPacientes);
            Name = "frmRegistrarPaciente";
            Text = "Registrar Paciente";
            Load += frmRegistrarPaciente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistroPacientes;
        private Label lblCedula;
        private TextBox txtCedula;
        private TextBox txtNombreCompleto;
        private Label lblNombre;
        private TextBox txtEdad;
        private Label lblEdad;
        private Label lblSexo;
        private ComboBox cmbSexo;
        private Label lblDiagnostico;
        private TextBox txtDiagnostico;
        private Label lblEstado;
        private ComboBox cmbEstado;
        private Label lblFechaIngreso;
        private DateTimePicker dtpFechaIngreso;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Button btnVolver;
        private Splitter splitter1;
        private Splitter splitter2;
    }
}