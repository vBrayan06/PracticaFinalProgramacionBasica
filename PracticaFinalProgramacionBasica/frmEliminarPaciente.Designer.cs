namespace PracticaFinalProgramacionBasica
{
    partial class frmEliminarPaciente
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
            btnBuscar = new Button();
            txtCedula = new TextBox();
            lblCedula = new Label();
            lblEliminarPaciente = new Label();
            lblEstado = new Label();
            lblDiagnostico = new Label();
            lblSexo = new Label();
            lblEdad = new Label();
            lblNombre = new Label();
            lblEstadoInfo = new Label();
            lblDiagnosticoInfo = new Label();
            lblSexoInfo = new Label();
            lblEdadInfo = new Label();
            lblNombreInfo = new Label();
            btnVolver = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(456, 104);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(93, 28);
            btnBuscar.TabIndex = 41;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(295, 107);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(155, 23);
            txtCedula.TabIndex = 40;
            txtCedula.TextChanged += txtCedula_TextChanged;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCedula.Location = new Point(114, 106);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(182, 25);
            lblCedula.TabIndex = 39;
            lblCedula.Text = "Cédula del Paciente:";
            // 
            // lblEliminarPaciente
            // 
            lblEliminarPaciente.AutoSize = true;
            lblEliminarPaciente.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEliminarPaciente.Location = new Point(197, 9);
            lblEliminarPaciente.Name = "lblEliminarPaciente";
            lblEliminarPaciente.Size = new Size(238, 37);
            lblEliminarPaciente.TabIndex = 38;
            lblEliminarPaciente.Text = "Eliminar Paciente";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(114, 374);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(72, 25);
            lblEstado.TabIndex = 46;
            lblEstado.Text = "Estado:";
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiagnostico.Location = new Point(114, 324);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(116, 25);
            lblDiagnostico.TabIndex = 45;
            lblDiagnostico.Text = "Diagnóstico:";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSexo.Location = new Point(114, 274);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(56, 25);
            lblSexo.TabIndex = 44;
            lblSexo.Text = "Sexo:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEdad.Location = new Point(114, 224);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(58, 25);
            lblEdad.TabIndex = 43;
            lblEdad.Text = "Edad:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(114, 174);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(85, 25);
            lblNombre.TabIndex = 42;
            lblNombre.Text = "Nombre:";
            // 
            // lblEstadoInfo
            // 
            lblEstadoInfo.AutoSize = true;
            lblEstadoInfo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstadoInfo.Location = new Point(326, 374);
            lblEstadoInfo.Name = "lblEstadoInfo";
            lblEstadoInfo.Size = new Size(180, 25);
            lblEstadoInfo.TabIndex = 51;
            lblEstadoInfo.Text = "Estado del paciente:";
            lblEstadoInfo.Visible = false;
            lblEstadoInfo.Click += lblEstadoInfo_Click;
            // 
            // lblDiagnosticoInfo
            // 
            lblDiagnosticoInfo.AutoSize = true;
            lblDiagnosticoInfo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiagnosticoInfo.Location = new Point(326, 324);
            lblDiagnosticoInfo.Name = "lblDiagnosticoInfo";
            lblDiagnosticoInfo.Size = new Size(116, 25);
            lblDiagnosticoInfo.TabIndex = 50;
            lblDiagnosticoInfo.Text = "Diagnóstico:";
            lblDiagnosticoInfo.Visible = false;
            lblDiagnosticoInfo.Click += lblDiagnosticoInfo_Click;
            // 
            // lblSexoInfo
            // 
            lblSexoInfo.AutoSize = true;
            lblSexoInfo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSexoInfo.Location = new Point(326, 274);
            lblSexoInfo.Name = "lblSexoInfo";
            lblSexoInfo.Size = new Size(56, 25);
            lblSexoInfo.TabIndex = 49;
            lblSexoInfo.Text = "Sexo:";
            lblSexoInfo.Visible = false;
            lblSexoInfo.Click += lblSexoInfo_Click;
            // 
            // lblEdadInfo
            // 
            lblEdadInfo.AutoSize = true;
            lblEdadInfo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEdadInfo.Location = new Point(326, 224);
            lblEdadInfo.Name = "lblEdadInfo";
            lblEdadInfo.Size = new Size(58, 25);
            lblEdadInfo.TabIndex = 48;
            lblEdadInfo.Text = "Edad:";
            lblEdadInfo.Visible = false;
            lblEdadInfo.Click += lblEdadInfo_Click;
            // 
            // lblNombreInfo
            // 
            lblNombreInfo.AutoSize = true;
            lblNombreInfo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreInfo.Location = new Point(326, 174);
            lblNombreInfo.Name = "lblNombreInfo";
            lblNombreInfo.Size = new Size(85, 25);
            lblNombreInfo.TabIndex = 47;
            lblNombreInfo.Text = "Nombre:";
            lblNombreInfo.Visible = false;
            lblNombreInfo.Click += lblNombreInfo_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnVolver.Location = new Point(346, 483);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(203, 44);
            btnVolver.TabIndex = 53;
            btnVolver.Text = "Volver al Menú";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnEliminar.Location = new Point(114, 483);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(203, 44);
            btnEliminar.TabIndex = 52;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmEliminarPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(663, 552);
            Controls.Add(btnVolver);
            Controls.Add(btnEliminar);
            Controls.Add(lblEstadoInfo);
            Controls.Add(lblDiagnosticoInfo);
            Controls.Add(lblSexoInfo);
            Controls.Add(lblEdadInfo);
            Controls.Add(lblNombreInfo);
            Controls.Add(lblEstado);
            Controls.Add(lblDiagnostico);
            Controls.Add(lblSexo);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            Controls.Add(btnBuscar);
            Controls.Add(txtCedula);
            Controls.Add(lblCedula);
            Controls.Add(lblEliminarPaciente);
            Name = "frmEliminarPaciente";
            Text = "Eliminar Paciente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private TextBox txtCedula;
        private Label lblCedula;
        private Label lblEliminarPaciente;
        private Label lblEstado;
        private Label lblDiagnostico;
        private Label lblSexo;
        private Label lblEdad;
        private Label lblNombre;
        private Label lblEstadoInfo;
        private Label lblDiagnosticoInfo;
        private Label lblSexoInfo;
        private Label lblEdadInfo;
        private Label lblNombreInfo;
        private Button btnVolver;
        private Button btnEliminar;
    }
}