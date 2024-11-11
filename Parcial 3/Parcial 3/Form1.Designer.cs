namespace Parcial_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView_Producto = new DataGridView();
            button1 = new Button();
            textBox_Nombre = new TextBox();
            textBox_PrecioActual = new TextBox();
            textBox_Descripcion = new TextBox();
            textBox_Stock = new TextBox();
            button_Buscar = new Button();
            tb_Id = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Producto).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_Producto
            // 
            dataGridView_Producto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Producto.Location = new Point(94, 190);
            dataGridView_Producto.Name = "dataGridView_Producto";
            dataGridView_Producto.Size = new Size(616, 150);
            dataGridView_Producto.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(503, 76);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox_Nombre
            // 
            textBox_Nombre.Location = new Point(141, 53);
            textBox_Nombre.Name = "textBox_Nombre";
            textBox_Nombre.PlaceholderText = "Nombre";
            textBox_Nombre.Size = new Size(125, 23);
            textBox_Nombre.TabIndex = 2;
            // 
            // textBox_PrecioActual
            // 
            textBox_PrecioActual.Location = new Point(314, 108);
            textBox_PrecioActual.Name = "textBox_PrecioActual";
            textBox_PrecioActual.PlaceholderText = "PrecioActual";
            textBox_PrecioActual.Size = new Size(125, 23);
            textBox_PrecioActual.TabIndex = 3;
            // 
            // textBox_Descripcion
            // 
            textBox_Descripcion.Location = new Point(60, 108);
            textBox_Descripcion.Name = "textBox_Descripcion";
            textBox_Descripcion.PlaceholderText = "Descripcion";
            textBox_Descripcion.Size = new Size(206, 23);
            textBox_Descripcion.TabIndex = 4;
            // 
            // textBox_Stock
            // 
            textBox_Stock.Location = new Point(314, 53);
            textBox_Stock.Name = "textBox_Stock";
            textBox_Stock.PlaceholderText = "Stock";
            textBox_Stock.Size = new Size(125, 23);
            textBox_Stock.TabIndex = 5;
            // 
            // button_Buscar
            // 
            button_Buscar.Location = new Point(536, 19);
            button_Buscar.Name = "button_Buscar";
            button_Buscar.Size = new Size(66, 24);
            button_Buscar.TabIndex = 6;
            button_Buscar.Text = "button2";
            button_Buscar.UseVisualStyleBackColor = true;
            // 
            // tb_Id
            // 
            tb_Id.Location = new Point(316, 16);
            tb_Id.Name = "tb_Id";
            tb_Id.Size = new Size(193, 23);
            tb_Id.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb_Id);
            Controls.Add(button_Buscar);
            Controls.Add(textBox_Stock);
            Controls.Add(textBox_Descripcion);
            Controls.Add(textBox_PrecioActual);
            Controls.Add(textBox_Nombre);
            Controls.Add(button1);
            Controls.Add(dataGridView_Producto);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Producto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_Producto;
        private Button button1;
        private TextBox textBox_Nombre;
        private TextBox textBox_PrecioActual;
        private TextBox textBox_Descripcion;
        private TextBox textBox_Stock;
        private Button button_Buscar;
        private TextBox tb_Id;
    }
}
