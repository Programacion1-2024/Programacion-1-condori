namespace CPresentacion.Empleado
{
    partial class FrmEmpleado
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
            tabControlPrincipal = new TabControl();
            tabListado = new TabPage();
            dgvListadoEmpleados = new DataGridView();
            tabModificacion = new TabPage();
            tbIdEmpleado = new TextBox();
            label8 = new Label();
            btnBaja = new Button();
            btnModificar = new Button();
            tbSueldoModificacion = new TextBox();
            btnBuscar = new Button();
            label7 = new Label();
            btnGuardarAlta = new Button();
            label1 = new Label();
            label2 = new Label();
            tbEmailModificacion = new TextBox();
            label3 = new Label();
            tbDocumentoModificacion = new TextBox();
            label4 = new Label();
            tbTelefonoModificacion = new TextBox();
            label5 = new Label();
            tbApellidoModificacion = new TextBox();
            label6 = new Label();
            tbNombreModificacion = new TextBox();
            cbCargo = new ComboBox();
            tabControlPrincipal.SuspendLayout();
            tabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadoEmpleados).BeginInit();
            tabModificacion.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            tabControlPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlPrincipal.Controls.Add(tabListado);
            tabControlPrincipal.Controls.Add(tabModificacion);
            tabControlPrincipal.Location = new Point(1, 3);
            tabControlPrincipal.Name = "tabControlPrincipal";
            tabControlPrincipal.SelectedIndex = 0;
            tabControlPrincipal.Size = new Size(734, 498);
            tabControlPrincipal.TabIndex = 1;
            // 
            // tabListado
            // 
            tabListado.Controls.Add(dgvListadoEmpleados);
            tabListado.Location = new Point(4, 24);
            tabListado.Name = "tabListado";
            tabListado.Padding = new Padding(3);
            tabListado.Size = new Size(726, 470);
            tabListado.TabIndex = 0;
            tabListado.Text = "Listado";
            tabListado.UseVisualStyleBackColor = true;
            // 
            // dgvListadoEmpleados
            // 
            dgvListadoEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListadoEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListadoEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoEmpleados.Location = new Point(0, 0);
            dgvListadoEmpleados.Name = "dgvListadoEmpleados";
            dgvListadoEmpleados.Size = new Size(825, 470);
            dgvListadoEmpleados.TabIndex = 2;
            // 
            // tabModificacion
            // 
            tabModificacion.Controls.Add(cbCargo);
            tabModificacion.Controls.Add(tbIdEmpleado);
            tabModificacion.Controls.Add(label8);
            tabModificacion.Controls.Add(btnBaja);
            tabModificacion.Controls.Add(btnModificar);
            tabModificacion.Controls.Add(tbSueldoModificacion);
            tabModificacion.Controls.Add(btnBuscar);
            tabModificacion.Controls.Add(label7);
            tabModificacion.Controls.Add(btnGuardarAlta);
            tabModificacion.Controls.Add(label1);
            tabModificacion.Controls.Add(label2);
            tabModificacion.Controls.Add(tbEmailModificacion);
            tabModificacion.Controls.Add(label3);
            tabModificacion.Controls.Add(tbDocumentoModificacion);
            tabModificacion.Controls.Add(label4);
            tabModificacion.Controls.Add(tbTelefonoModificacion);
            tabModificacion.Controls.Add(label5);
            tabModificacion.Controls.Add(tbApellidoModificacion);
            tabModificacion.Controls.Add(label6);
            tabModificacion.Controls.Add(tbNombreModificacion);
            tabModificacion.Location = new Point(4, 24);
            tabModificacion.Name = "tabModificacion";
            tabModificacion.Padding = new Padding(3);
            tabModificacion.Size = new Size(726, 470);
            tabModificacion.TabIndex = 2;
            tabModificacion.Text = "Empleados";
            tabModificacion.UseVisualStyleBackColor = true;
            // 
            // tbIdEmpleado
            // 
            tbIdEmpleado.Location = new Point(352, 18);
            tbIdEmpleado.Name = "tbIdEmpleado";
            tbIdEmpleado.Size = new Size(158, 23);
            tbIdEmpleado.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(127, 200);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 30;
            label8.Text = "Cargo";
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(502, 273);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(75, 23);
            btnBaja.TabIndex = 29;
            btnBaja.Text = "Baja";
            btnBaja.UseVisualStyleBackColor = true;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(352, 273);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 28;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // tbSueldoModificacion
            // 
            tbSueldoModificacion.Location = new Point(465, 149);
            tbSueldoModificacion.Name = "tbSueldoModificacion";
            tbSueldoModificacion.Size = new Size(158, 23);
            tbSueldoModificacion.TabIndex = 27;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(538, 19);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 26;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(259, 26);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 25;
            label7.Text = "ID Empleado";
            // 
            // btnGuardarAlta
            // 
            btnGuardarAlta.Location = new Point(207, 273);
            btnGuardarAlta.Name = "btnGuardarAlta";
            btnGuardarAlta.Size = new Size(75, 23);
            btnGuardarAlta.TabIndex = 20;
            btnGuardarAlta.Text = "Guardar";
            btnGuardarAlta.UseVisualStyleBackColor = true;
            btnGuardarAlta.Click += btnGuardarAlta_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(401, 157);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 23;
            label1.Text = "Sueldo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 157);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 22;
            label2.Text = "Email";
            // 
            // tbEmailModificacion
            // 
            tbEmailModificacion.Location = new Point(207, 151);
            tbEmailModificacion.Name = "tbEmailModificacion";
            tbEmailModificacion.Size = new Size(158, 23);
            tbEmailModificacion.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 110);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 21;
            label3.Text = "Documento";
            // 
            // tbDocumentoModificacion
            // 
            tbDocumentoModificacion.Location = new Point(207, 104);
            tbDocumentoModificacion.Name = "tbDocumentoModificacion";
            tbDocumentoModificacion.Size = new Size(158, 23);
            tbDocumentoModificacion.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(401, 108);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 19;
            label4.Text = "Telefono";
            // 
            // tbTelefonoModificacion
            // 
            tbTelefonoModificacion.Location = new Point(465, 102);
            tbTelefonoModificacion.Name = "tbTelefonoModificacion";
            tbTelefonoModificacion.Size = new Size(158, 23);
            tbTelefonoModificacion.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(402, 61);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 16;
            label5.Text = "Apellido";
            // 
            // tbApellidoModificacion
            // 
            tbApellidoModificacion.Location = new Point(465, 55);
            tbApellidoModificacion.Name = "tbApellidoModificacion";
            tbApellidoModificacion.Size = new Size(158, 23);
            tbApellidoModificacion.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(127, 61);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 13;
            label6.Text = "Nombre";
            // 
            // tbNombreModificacion
            // 
            tbNombreModificacion.Location = new Point(207, 58);
            tbNombreModificacion.Name = "tbNombreModificacion";
            tbNombreModificacion.Size = new Size(158, 23);
            tbNombreModificacion.TabIndex = 11;
            // 
            // cbCargo
            // 
            cbCargo.FormattingEnabled = true;
            cbCargo.Items.AddRange(new object[] { "Gerente", "Superior", "Asistente ", "Operario" });
            cbCargo.Location = new Point(208, 192);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(157, 23);
            cbCargo.TabIndex = 33;
            cbCargo.SelectedIndexChanged += cbCargo_SelectedIndexChanged;
            // 
            // FrmEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 507);
            Controls.Add(tabControlPrincipal);
            Name = "FrmEmpleado";
            Text = "FrmEmpleado";
            tabControlPrincipal.ResumeLayout(false);
            tabListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListadoEmpleados).EndInit();
            tabModificacion.ResumeLayout(false);
            tabModificacion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlPrincipal;
        private TabPage tabListado;
        private TabPage tabAlta;
        private Button btnGuardarAlta;
        private TextBox tbCargoAlta;
        private Label lbCargo;
        private Label lbEmailAlta;
        private TextBox tbEmailAlta;
        private Label lbNacionalidadAlta;
        private TextBox tbNacionalidadAlta;
        private Label lbTelefonoAlta;
        private TextBox tbTelefonoAlta;
        private Label lbApellidoAlta;
        private TextBox tbApellidoAlta;
        private Label lblNombreAlta;
        private TextBox tbNombreAlta;
        private TabPage tabModificacion;
        private Button btnBuscar;
        private Label label7;
        private TextBox tbIdAutor;
        private Label label1;
        private Label label2;
        private TextBox tbEmailModificacion;
        private Label label3;
        private TextBox tbDocumentoModificacion;
        private Label label4;
        private TextBox tbTelefonoModificacion;
        private Label label5;
        private TextBox tbApellidoModificacion;
        private Label label6;
        private TextBox tbNombreModificacion;
        private TabPage tabBaja;
        private DataGridView dgvListadoEmpleados;
        private TextBox tbSueldoModificacion;
        private Button btnModificar;
        private Button btnBaja;
        private Label label8;
        private TextBox tbDocumentoAlta;
        private Label label10;
        private TextBox tbFechaAlta;
        private Label label9;
        private TextBox tbSueldoAlta;
        private TextBox tbIdEmpleado;
        private ComboBox cbCargo;
    }
}