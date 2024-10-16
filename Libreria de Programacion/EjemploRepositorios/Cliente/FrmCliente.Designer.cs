namespace CPresentacion.Cliente
{
    partial class FrmCliente
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
            dgvListadoClientes = new DataGridView();
            tabABM = new TabPage();
            btnBuscar = new Button();
            tbIdCliente = new TextBox();
            tbApellido = new TextBox();
            tbDocumento = new TextBox();
            tbTelefono = new TextBox();
            tbEmail = new TextBox();
            tbNacionalidad = new TextBox();
            tbNombre = new TextBox();
            cbIva = new ComboBox();
            cbSocio = new ComboBox();
            label8 = new Label();
            label6 = new Label();
            label3 = new Label();
            label7 = new Label();
            lbNombre = new Label();
            label5 = new Label();
            label4 = new Label();
            lbApellido = new Label();
            label2 = new Label();
            label1 = new Label();
            btnModificacion = new Button();
            btnBaja = new Button();
            btnAlta = new Button();
            tabControlPrincipal.SuspendLayout();
            tabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadoClientes).BeginInit();
            tabABM.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            tabControlPrincipal.Controls.Add(tabListado);
            tabControlPrincipal.Controls.Add(tabABM);
            tabControlPrincipal.Location = new Point(2, 0);
            tabControlPrincipal.Name = "tabControlPrincipal";
            tabControlPrincipal.SelectedIndex = 0;
            tabControlPrincipal.Size = new Size(796, 449);
            tabControlPrincipal.TabIndex = 0;
            // 
            // tabListado
            // 
            tabListado.Controls.Add(dgvListadoClientes);
            tabListado.Location = new Point(4, 24);
            tabListado.Name = "tabListado";
            tabListado.Padding = new Padding(3);
            tabListado.Size = new Size(788, 421);
            tabListado.TabIndex = 0;
            tabListado.Text = "Listado";
            tabListado.UseVisualStyleBackColor = true;
            // 
            // dgvListadoClientes
            // 
            dgvListadoClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoClientes.Dock = DockStyle.Fill;
            dgvListadoClientes.Location = new Point(3, 3);
            dgvListadoClientes.Name = "dgvListadoClientes";
            dgvListadoClientes.Size = new Size(782, 415);
            dgvListadoClientes.TabIndex = 0;
            // 
            // tabABM
            // 
            tabABM.Controls.Add(btnBuscar);
            tabABM.Controls.Add(tbIdCliente);
            tabABM.Controls.Add(tbApellido);
            tabABM.Controls.Add(tbDocumento);
            tabABM.Controls.Add(tbTelefono);
            tabABM.Controls.Add(tbEmail);
            tabABM.Controls.Add(tbNacionalidad);
            tabABM.Controls.Add(tbNombre);
            tabABM.Controls.Add(cbIva);
            tabABM.Controls.Add(cbSocio);
            tabABM.Controls.Add(label8);
            tabABM.Controls.Add(label6);
            tabABM.Controls.Add(label3);
            tabABM.Controls.Add(label7);
            tabABM.Controls.Add(lbNombre);
            tabABM.Controls.Add(label5);
            tabABM.Controls.Add(label4);
            tabABM.Controls.Add(lbApellido);
            tabABM.Controls.Add(label2);
            tabABM.Controls.Add(label1);
            tabABM.Controls.Add(btnModificacion);
            tabABM.Controls.Add(btnBaja);
            tabABM.Controls.Add(btnAlta);
            tabABM.Location = new Point(4, 24);
            tabABM.Name = "tabABM";
            tabABM.Padding = new Padding(3);
            tabABM.Size = new Size(788, 421);
            tabABM.TabIndex = 1;
            tabABM.Text = "ABMCliente";
            tabABM.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(526, 13);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(101, 23);
            btnBuscar.TabIndex = 22;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // tbIdCliente
            // 
            tbIdCliente.Location = new Point(316, 13);
            tbIdCliente.Name = "tbIdCliente";
            tbIdCliente.Size = new Size(165, 23);
            tbIdCliente.TabIndex = 21;
            // 
            // tbApellido
            // 
            tbApellido.Location = new Point(546, 56);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(165, 23);
            tbApellido.TabIndex = 20;
            // 
            // tbDocumento
            // 
            tbDocumento.Location = new Point(247, 120);
            tbDocumento.Name = "tbDocumento";
            tbDocumento.Size = new Size(165, 23);
            tbDocumento.TabIndex = 19;
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(546, 120);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(165, 23);
            tbTelefono.TabIndex = 18;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(546, 187);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(165, 23);
            tbEmail.TabIndex = 17;
            // 
            // tbNacionalidad
            // 
            tbNacionalidad.Location = new Point(247, 187);
            tbNacionalidad.Name = "tbNacionalidad";
            tbNacionalidad.Size = new Size(165, 23);
            tbNacionalidad.TabIndex = 16;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(247, 56);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(165, 23);
            tbNombre.TabIndex = 15;
            // 
            // cbIva
            // 
            cbIva.FormattingEnabled = true;
            cbIva.Location = new Point(546, 256);
            cbIva.Name = "cbIva";
            cbIva.Size = new Size(165, 23);
            cbIva.TabIndex = 14;
            // 
            // cbSocio
            // 
            cbSocio.FormattingEnabled = true;
            cbSocio.Location = new Point(247, 256);
            cbSocio.Name = "cbSocio";
            cbSocio.Size = new Size(165, 23);
            cbSocio.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(163, 259);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 12;
            label8.Text = "Socio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(459, 259);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 11;
            label6.Text = "Paga IVA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 123);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 10;
            label3.Text = "Documento:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(459, 190);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 9;
            label7.Text = "Email:";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(163, 59);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(54, 15);
            lbNombre.TabIndex = 8;
            lbNombre.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(163, 138);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(163, 190);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 6;
            label4.Text = "Nacionalidad:";
            // 
            // lbApellido
            // 
            lbApellido.AutoSize = true;
            lbApellido.Location = new Point(459, 59);
            lbApellido.Name = "lbApellido";
            lbApellido.Size = new Size(54, 15);
            lbApellido.TabIndex = 5;
            lbApellido.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(459, 123);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 4;
            label2.Text = "Teléfono:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 17);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 3;
            label1.Text = "ID Cliente:";
            // 
            // btnModificacion
            // 
            btnModificacion.Location = new Point(344, 314);
            btnModificacion.Name = "btnModificacion";
            btnModificacion.Size = new Size(101, 23);
            btnModificacion.TabIndex = 2;
            btnModificacion.Text = "Modificar";
            btnModificacion.UseVisualStyleBackColor = true;
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(513, 314);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(101, 23);
            btnBaja.TabIndex = 1;
            btnBaja.Text = "Dar de Baja";
            btnBaja.UseVisualStyleBackColor = true;
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(163, 314);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(101, 23);
            btnAlta.TabIndex = 0;
            btnAlta.Text = "Dar de Alta";
            btnAlta.UseVisualStyleBackColor = true;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlPrincipal);
            Name = "FrmCliente";
            Text = "FrmCliente";
            tabControlPrincipal.ResumeLayout(false);
            tabListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListadoClientes).EndInit();
            tabABM.ResumeLayout(false);
            tabABM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlPrincipal;
        private TabPage tabListado;
        private TabPage tabABM;
        private DataGridView dgvListadoClientes;
        private Label label1;
        private Button btnModificacion;
        private Button btnBaja;
        private Button btnAlta;
        private Label label7;
        private Label lbNombre;
        private Label label5;
        private Label label4;
        private Label lbApellido;
        private Label label2;
        private Label label3;
        private Label label8;
        private Label label6;
        private ComboBox cbIva;
        private ComboBox cbSocio;
        private Button btnBuscar;
        private TextBox tbIdCliente;
        private TextBox tbApellido;
        private TextBox tbDocumento;
        private TextBox tbTelefono;
        private TextBox tbEmail;
        private TextBox tbNacionalidad;
        private TextBox tbNombre;
    }
}