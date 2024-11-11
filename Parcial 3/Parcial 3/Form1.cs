using LOGICA.Contracts;

namespace Parcial_3
{
    public partial class Form1 : Form
    {

        private IProductoLogic _ProductoLogic;

        public Form1(IProductoLogic ProductoLogic)
        {
            InitializeComponent();
            _ProductoLogic = ProductoLogic;
        }
        private void CargarListadoClientes()
        {
            List<dynamic> Producto = _ProductoLogic.ObtenerProductosParaListado();
            dataGridView_Producto.DataSource = Producto;
            dataGridView_Producto.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_Id.Text == "")
            {
                string Nombre = textBox_Nombre.Text;
                string Descripcion = textBox_Descripcion.Text;
                int stock = int.Parse(textBox_Stock.Text);
                int PrecioActual = int.Parse(textBox_PrecioActual.Text);


                try
                {
                    _ProductoLogic.AltaProducto(Nombre, Descripcion, stock, PrecioActual);
                    MessageBox.Show("Se ha creado el producto");

                    textBox_Nombre.Clear();
                    textBox_Descripcion.Clear();
                    textBox_Stock.Clear();
                    textBox_PrecioActual.Clear();
                    CargarListadoClientes();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
