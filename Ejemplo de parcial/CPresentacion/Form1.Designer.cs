namespace CPresentacion
{
    partial class Form1
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
            Pestañas = new TabControl();
            tabPage1 = new TabPage();
            dgvClientes = new DataGridView();
            tabPage2 = new TabPage();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            tb_Id = new TextBox();
            tb_Dni = new TextBox();
            tb_Apellido = new TextBox();
            tb_Nombre = new TextBox();
            btn_Buscar = new Button();
            btn_Modificar = new Button();
            btn_Baja = new Button();
            btn_Alta = new Button();
            Pestañas.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // Pestañas
            // 
            Pestañas.Controls.Add(tabPage1);
            Pestañas.Controls.Add(tabPage2);
            Pestañas.Location = new Point(0, -1);
            Pestañas.Name = "Pestañas";
            Pestañas.SelectedIndex = 0;
            Pestañas.Size = new Size(616, 481);
            Pestañas.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvClientes);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(608, 453);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Listado Clientes";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(0, 0);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(608, 453);
            dgvClientes.TabIndex = 0;
            dgvClientes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(tb_Id);
            tabPage2.Controls.Add(tb_Dni);
            tabPage2.Controls.Add(tb_Apellido);
            tabPage2.Controls.Add(tb_Nombre);
            tabPage2.Controls.Add(btn_Buscar);
            tabPage2.Controls.Add(btn_Modificar);
            tabPage2.Controls.Add(btn_Baja);
            tabPage2.Controls.Add(btn_Alta);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(608, 453);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Crud Cliente";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(252, 73);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 18;
            label5.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(447, 73);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 17;
            label4.Text = "DNI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 73);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 15;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 24);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 12;
            label1.Text = "Introduzca el ID del Cliente:";
            label1.Click += label1_Click;
            // 
            // tb_Id
            // 
            tb_Id.Location = new Point(252, 16);
            tb_Id.Name = "tb_Id";
            tb_Id.Size = new Size(113, 23);
            tb_Id.TabIndex = 11;
            // 
            // tb_Dni
            // 
            tb_Dni.Location = new Point(447, 91);
            tb_Dni.Name = "tb_Dni";
            tb_Dni.Size = new Size(113, 23);
            tb_Dni.TabIndex = 9;
            // 
            // tb_Apellido
            // 
            tb_Apellido.Location = new Point(252, 91);
            tb_Apellido.Name = "tb_Apellido";
            tb_Apellido.Size = new Size(113, 23);
            tb_Apellido.TabIndex = 7;
            // 
            // tb_Nombre
            // 
            tb_Nombre.Location = new Point(47, 91);
            tb_Nombre.Name = "tb_Nombre";
            tb_Nombre.Size = new Size(113, 23);
            tb_Nombre.TabIndex = 5;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new Point(447, 16);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(113, 23);
            btn_Buscar.TabIndex = 4;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // btn_Modificar
            // 
            btn_Modificar.Location = new Point(447, 382);
            btn_Modificar.Name = "btn_Modificar";
            btn_Modificar.Size = new Size(113, 23);
            btn_Modificar.TabIndex = 3;
            btn_Modificar.Text = "Modificar";
            btn_Modificar.UseVisualStyleBackColor = true;
            btn_Modificar.Click += btn_Modificar_Click;
            // 
            // btn_Baja
            // 
            btn_Baja.Location = new Point(252, 382);
            btn_Baja.Name = "btn_Baja";
            btn_Baja.Size = new Size(113, 23);
            btn_Baja.TabIndex = 2;
            btn_Baja.Text = "Dar de Baja";
            btn_Baja.UseVisualStyleBackColor = true;
            btn_Baja.Click += btn_Baja_Click;
            // 
            // btn_Alta
            // 
            btn_Alta.Location = new Point(47, 382);
            btn_Alta.Name = "btn_Alta";
            btn_Alta.Size = new Size(113, 23);
            btn_Alta.TabIndex = 1;
            btn_Alta.Text = "Dar de Alta";
            btn_Alta.UseVisualStyleBackColor = true;
            btn_Alta.Click += btn_Alta_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 476);
            Controls.Add(Pestañas);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Pestañas.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Pestañas;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvClientes;
        private Button btn_Alta;
        private Button btn_Buscar;
        private Button btn_Modificar;
        private Button btn_Baja;
        private TextBox tb_Apellido;
        private TextBox tb_Nombre;
        private TextBox tb_Dni;
        private Label label1;
        private TextBox tb_Id;
        private Label label2;
        private Label label5;
        private Label label4;
    }
}