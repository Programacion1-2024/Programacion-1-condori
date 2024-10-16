namespace CPresentacion
{
    partial class ABMAutor
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
            dgvListadoAutores = new DataGridView();
            tabModificacion = new TabPage();
            BotonEliminar = new Button();
            BotonModificar = new Button();
            btnBuscar = new Button();
            label7 = new Label();
            tbIdAutor = new TextBox();
            btnGuardarModificacion = new Button();
            tbBiografiaModificacion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbEmailModificacion = new TextBox();
            label3 = new Label();
            tbNacionalidadModificacion = new TextBox();
            label4 = new Label();
            tbTelefonoModificacion = new TextBox();
            label5 = new Label();
            tbApellidoModificacion = new TextBox();
            label6 = new Label();
            tbNombreModificacion = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            tabControlPrincipal.SuspendLayout();
            tabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadoAutores).BeginInit();
            tabModificacion.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            tabControlPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlPrincipal.Controls.Add(tabListado);
            tabControlPrincipal.Controls.Add(tabModificacion);
            tabControlPrincipal.Location = new Point(12, 12);
            tabControlPrincipal.Name = "tabControlPrincipal";
            tabControlPrincipal.SelectedIndex = 0;
            tabControlPrincipal.Size = new Size(867, 486);
            tabControlPrincipal.TabIndex = 0;
            tabControlPrincipal.SelectedIndexChanged += tabControlPrincipal_SelectedIndexChanged;
            // 
            // tabListado
            // 
            tabListado.Controls.Add(dgvListadoAutores);
            tabListado.Location = new Point(4, 24);
            tabListado.Name = "tabListado";
            tabListado.Padding = new Padding(3);
            tabListado.Size = new Size(859, 458);
            tabListado.TabIndex = 0;
            tabListado.Text = "Listado";
            tabListado.UseVisualStyleBackColor = true;
            // 
            // dgvListadoAutores
            // 
            dgvListadoAutores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListadoAutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListadoAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoAutores.Location = new Point(3, 3);
            dgvListadoAutores.Name = "dgvListadoAutores";
            dgvListadoAutores.Size = new Size(850, 452);
            dgvListadoAutores.TabIndex = 0;
            // 
            // tabModificacion
            // 
            tabModificacion.Controls.Add(BotonEliminar);
            tabModificacion.Controls.Add(BotonModificar);
            tabModificacion.Controls.Add(btnBuscar);
            tabModificacion.Controls.Add(label7);
            tabModificacion.Controls.Add(tbIdAutor);
            tabModificacion.Controls.Add(btnGuardarModificacion);
            tabModificacion.Controls.Add(tbBiografiaModificacion);
            tabModificacion.Controls.Add(label1);
            tabModificacion.Controls.Add(label2);
            tabModificacion.Controls.Add(tbEmailModificacion);
            tabModificacion.Controls.Add(label3);
            tabModificacion.Controls.Add(tbNacionalidadModificacion);
            tabModificacion.Controls.Add(label4);
            tabModificacion.Controls.Add(tbTelefonoModificacion);
            tabModificacion.Controls.Add(label5);
            tabModificacion.Controls.Add(tbApellidoModificacion);
            tabModificacion.Controls.Add(label6);
            tabModificacion.Controls.Add(tbNombreModificacion);
            tabModificacion.Location = new Point(4, 24);
            tabModificacion.Name = "tabModificacion";
            tabModificacion.Padding = new Padding(3);
            tabModificacion.Size = new Size(859, 458);
            tabModificacion.TabIndex = 2;
            tabModificacion.Text = "Modificacion";
            tabModificacion.UseVisualStyleBackColor = true;
            // 
            // BotonEliminar
            // 
            BotonEliminar.Location = new Point(548, 376);
            BotonEliminar.Name = "BotonEliminar";
            BotonEliminar.Size = new Size(75, 23);
            BotonEliminar.TabIndex = 28;
            BotonEliminar.Text = "Eliminar";
            BotonEliminar.UseVisualStyleBackColor = true;
            BotonEliminar.Click += BotonEliminar_Click;
            // 
            // BotonModificar
            // 
            BotonModificar.Location = new Point(207, 376);
            BotonModificar.Name = "BotonModificar";
            BotonModificar.Size = new Size(75, 23);
            BotonModificar.TabIndex = 27;
            BotonModificar.Text = "Guardar";
            BotonModificar.UseVisualStyleBackColor = true;
            BotonModificar.Click += BotonModificar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(538, 19);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 26;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(256, 23);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 25;
            label7.Text = "ID Autor";
            // 
            // tbIdAutor
            // 
            tbIdAutor.Location = new Point(339, 15);
            tbIdAutor.Name = "tbIdAutor";
            tbIdAutor.Size = new Size(158, 23);
            tbIdAutor.TabIndex = 24;
            // 
            // btnGuardarModificacion
            // 
            btnGuardarModificacion.Location = new Point(375, 376);
            btnGuardarModificacion.Name = "btnGuardarModificacion";
            btnGuardarModificacion.Size = new Size(75, 23);
            btnGuardarModificacion.TabIndex = 20;
            btnGuardarModificacion.Text = "Modificar";
            btnGuardarModificacion.UseVisualStyleBackColor = true;
            btnGuardarModificacion.Click += btnGuardarModificacion_Click;
            // 
            // tbBiografiaModificacion
            // 
            tbBiografiaModificacion.Location = new Point(207, 213);
            tbBiografiaModificacion.Multiline = true;
            tbBiografiaModificacion.Name = "tbBiografiaModificacion";
            tbBiografiaModificacion.Size = new Size(416, 127);
            tbBiografiaModificacion.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 216);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 23;
            label1.Text = "Biografia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 154);
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
            label3.Location = new Point(124, 107);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 21;
            label3.Text = "Nacionalidad";
            // 
            // tbNacionalidadModificacion
            // 
            tbNacionalidadModificacion.Location = new Point(207, 104);
            tbNacionalidadModificacion.Name = "tbNacionalidadModificacion";
            tbNacionalidadModificacion.Size = new Size(158, 23);
            tbNacionalidadModificacion.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 154);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 19;
            label4.Text = "Telefono";
            // 
            // tbTelefonoModificacion
            // 
            tbTelefonoModificacion.Location = new Point(465, 151);
            tbTelefonoModificacion.Name = "tbTelefonoModificacion";
            tbTelefonoModificacion.Size = new Size(158, 23);
            tbTelefonoModificacion.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(399, 58);
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
            label6.Location = new Point(124, 58);
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
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ABMAutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 510);
            Controls.Add(tabControlPrincipal);
            Name = "ABMAutor";
            Text = "ABMAutor";
            Load += ABMAutor_Load;
            tabControlPrincipal.ResumeLayout(false);
            tabListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListadoAutores).EndInit();
            tabModificacion.ResumeLayout(false);
            tabModificacion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlPrincipal;
        private TabPage tabListado;
        private TabPage tabModificacion;
        private OpenFileDialog openFileDialog1;
        private DataGridView dgvListadoAutores;
        private Label label7;
        private TextBox tbIdAutor;
        private Button btnGuardarModificacion;
        private TextBox tbBiografiaModificacion;
        private Label label1;
        private Label label2;
        private TextBox tbEmailModificacion;
        private Label label3;
        private TextBox tbNacionalidadModificacion;
        private Label label4;
        private TextBox tbTelefonoModificacion;
        private Label label5;
        private TextBox tbApellidoModificacion;
        private Label label6;
        private TextBox tbNombreModificacion;
        private Button btnBuscar;
        private Button BotonEliminar;
        private Button BotonModificar;
    }
}