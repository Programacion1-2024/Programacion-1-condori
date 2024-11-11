namespace CPresentacion
{
    partial class Menu
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
            btnAutor = new Button();
            btnEmpleado = new Button();
            btnCliente = new Button();
            panel1 = new Panel();
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            dgvListadoAutores = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadoAutores).BeginInit();
            SuspendLayout();
            // 
            // btnAutor
            // 
            btnAutor.Font = new Font("Forte", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAutor.Location = new Point(163, 61);
            btnAutor.Name = "btnAutor";
            btnAutor.Size = new Size(105, 26);
            btnAutor.TabIndex = 21;
            btnAutor.Text = "Carrito";
            btnAutor.UseVisualStyleBackColor = true;
            btnAutor.Click += btnAutor_Click;
            // 
            // btnEmpleado
            // 
            btnEmpleado.Font = new Font("Forte", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEmpleado.Location = new Point(385, 61);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(127, 26);
            btnEmpleado.TabIndex = 22;
            btnEmpleado.Text = "Categorias";
            btnEmpleado.UseVisualStyleBackColor = true;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = SystemColors.Window;
            btnCliente.Font = new Font("Forte", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCliente.Location = new Point(264, 61);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(127, 26);
            btnCliente.TabIndex = 23;
            btnCliente.Text = "Configuracion";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnEmpleado);
            panel1.Controls.Add(btnCliente);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btnAutor);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 87);
            panel1.TabIndex = 24;
            // 
            // button2
            // 
            button2.Font = new Font("Forte", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(508, 61);
            button2.Name = "button2";
            button2.Size = new Size(127, 26);
            button2.TabIndex = 27;
            button2.Text = "Novedades";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 11);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 26;
            label1.Text = "Book Store";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Font = new Font("Forte", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(491, 11);
            button1.Name = "button1";
            button1.Size = new Size(62, 23);
            button1.TabIndex = 25;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Forte", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(218, 11);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Titulo, Autor o ISBN";
            textBox1.Size = new Size(267, 24);
            textBox1.TabIndex = 0;
            // 
            // dgvListadoAutores
            // 
            dgvListadoAutores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListadoAutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListadoAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoAutores.Location = new Point(108, 139);
            dgvListadoAutores.Name = "dgvListadoAutores";
            dgvListadoAutores.Size = new Size(584, 231);
            dgvListadoAutores.TabIndex = 25;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvListadoAutores);
            Controls.Add(panel1);
            Name = "Menu";
            Text = "Menu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadoAutores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAutor;
        private Button btnEmpleado;
        private Button btnCliente;
        private Panel panel1;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dgvListadoAutores;
        private Label label1;
        private Button button2;
    }
}