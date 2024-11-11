using CEntidades.Entitis;
using CLogica.Contract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPresentacion
{
    public partial class Form1 : Form
    {
        private IClienteLogic _clienteLogic;

        public Form1(IClienteLogic clienteLogic)
        {
            InitializeComponent();
            _clienteLogic = clienteLogic;
        }

        private void CargarListadoClientes()
        {
            List<dynamic> cliente = _clienteLogic.ObtenerClientesParaListado();
            dgvClientes.DataSource = cliente;
            dgvClientes.Refresh();
        }
        private void tabControlPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Pestañas.SelectedIndex == 0)
            {
                CargarListadoClientes();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Pestañas.SelectedIndex == 0)
            {
                CargarListadoClientes();
            }
        }

        private void btn_Alta_Click(object sender, EventArgs e)
        {
            if (tb_Id.Text == "")
            {
                string Nombre = tb_Nombre.Text;
                string Apellido = tb_Apellido.Text;
                string Dni = tb_Dni.Text;


                try
                {
                    _clienteLogic.AltaCliente(Nombre, Apellido, Dni);
                    MessageBox.Show("Se ha creado el cliente");

                    tb_Nombre.Clear();
                    tb_Apellido.Clear();
                    tb_Dni.Clear();
                    CargarListadoClientes();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (tb_Id.Text != "")
            {
                string IdCliente = tb_Id.Text;
                string Nombre = tb_Nombre.Text;
                string Apellido = tb_Apellido.Text;
                string Dni = tb_Dni.Text;

                try
                {
                    _clienteLogic.ActualizarCliente(IdCliente, Nombre, Apellido, Dni);
                    MessageBox.Show("Se ha modificado el cliente");

                    tb_Id.Clear();
                    tb_Nombre.Clear();
                    tb_Apellido.Clear();
                    tb_Dni.Clear();

                    CargarListadoClientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_Baja_Click(object sender, EventArgs e)
        {
            if(tb_Id.Text != "")
            {
                string IdCliente = tb_Id.Text;

                try
                {
                    _clienteLogic.EliminarCliente(IdCliente);
                    MessageBox.Show("Se ha eliminado el cliente");

                    tb_Id.Clear();
                    tb_Nombre.Clear();
                    tb_Apellido.Clear();
                    tb_Dni.Clear();

                    CargarListadoClientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (tb_Id.Text != "")
            {
                int IdCliente = int.Parse(tb_Id.Text);

                try
                {
                    Cliente clienteNuevo = _clienteLogic.BuscarPorId(IdCliente);
                    if (clienteNuevo != null)
                    {
                        tb_Nombre.Text = clienteNuevo.Nombre;
                        tb_Apellido.Text = clienteNuevo.Apellido;
                        tb_Dni.Text = clienteNuevo.Dni;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }














        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


    }
}

