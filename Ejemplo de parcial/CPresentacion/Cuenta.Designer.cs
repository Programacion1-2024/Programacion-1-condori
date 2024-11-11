namespace CPresentacion
{
    partial class Cuenta
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
            dgvCuenta = new DataGridView();
            tabPage2 = new TabPage();
            cb_Cliente = new ComboBox();
            label3 = new Label();
            cb_Estado = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            tb_Id = new TextBox();
            tb_Saldo = new TextBox();
            tb_NroCuenta = new TextBox();
            btn_Buscar = new Button();
            btn_Modificar = new Button();
            btn_Baja = new Button();
            btn_Alta = new Button();
            Pestañas.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCuenta).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // Pestañas
            // 
            Pestañas.Controls.Add(tabPage1);
            Pestañas.Controls.Add(tabPage2);
            Pestañas.Location = new Point(2, 1);
            Pestañas.Name = "Pestañas";
            Pestañas.SelectedIndex = 0;
            Pestañas.Size = new Size(799, 481);
            Pestañas.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvCuenta);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(791, 453);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Listado Cuentas";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvCuenta
            // 
            dgvCuenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuenta.Location = new Point(0, 0);
            dgvCuenta.Name = "dgvCuenta";
            dgvCuenta.Size = new Size(791, 453);
            dgvCuenta.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cb_Cliente);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(cb_Estado);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(tb_Id);
            tabPage2.Controls.Add(tb_Saldo);
            tabPage2.Controls.Add(tb_NroCuenta);
            tabPage2.Controls.Add(btn_Buscar);
            tabPage2.Controls.Add(btn_Modificar);
            tabPage2.Controls.Add(btn_Baja);
            tabPage2.Controls.Add(btn_Alta);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(791, 453);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Crud Cuenta";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cb_Cliente
            // 
            cb_Cliente.FormattingEnabled = true;
            cb_Cliente.Location = new Point(47, 171);
            cb_Cliente.Name = "cb_Cliente";
            cb_Cliente.Size = new Size(113, 23);
            cb_Cliente.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 156);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 20;
            label3.Text = "Cliente:";
            // 
            // cb_Estado
            // 
            cb_Estado.FormattingEnabled = true;
            cb_Estado.Location = new Point(450, 91);
            cb_Estado.Name = "cb_Estado";
            cb_Estado.Size = new Size(113, 23);
            cb_Estado.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(255, 76);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 18;
            label5.Text = "Saldo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(450, 76);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 17;
            label4.Text = "Estado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 76);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 15;
            label2.Text = "Nro Cuenta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 27);
            label1.Name = "label1";
            label1.Size = new Size(161, 15);
            label1.TabIndex = 12;
            label1.Text = "Introduzca el ID de la Cuenta:";
            // 
            // tb_Id
            // 
            tb_Id.Location = new Point(252, 16);
            tb_Id.Name = "tb_Id";
            tb_Id.Size = new Size(113, 23);
            tb_Id.TabIndex = 11;
            // 
            // tb_Saldo
            // 
            tb_Saldo.Location = new Point(252, 91);
            tb_Saldo.Name = "tb_Saldo";
            tb_Saldo.Size = new Size(113, 23);
            tb_Saldo.TabIndex = 7;
            // 
            // tb_NroCuenta
            // 
            tb_NroCuenta.Location = new Point(47, 91);
            tb_NroCuenta.Name = "tb_NroCuenta";
            tb_NroCuenta.Size = new Size(113, 23);
            tb_NroCuenta.TabIndex = 5;
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
            // Cuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 480);
            Controls.Add(Pestañas);
            Name = "Cuenta";
            Text = "Cuenta";
            Load += Cuenta_Load;
            Pestañas.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCuenta).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Pestañas;
        private TabPage tabPage1;
        private DataGridView dgvCuenta;
        private TabPage tabPage2;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox tb_Id;
        private TextBox tb_Saldo;
        private TextBox tb_NroCuenta;
        private Button btn_Buscar;
        private Button btn_Modificar;
        private Button btn_Baja;
        private Button btn_Alta;
        private ComboBox cb_Estado;
        private ComboBox cb_Cliente;
        private Label label3;
    }
}