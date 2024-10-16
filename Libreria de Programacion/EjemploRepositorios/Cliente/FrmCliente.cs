using CLogica.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPresentacion.Cliente
{
    public partial class FrmCliente : Form
    {

        private IClienteLogic _clienteLogic;


        public FrmCliente(IClienteLogic clienteLogic)
        {
            InitializeComponent();
            _clienteLogic = clienteLogic;
        }

        private void tabControlPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlPrincipal.SelectedIndex == 0)
            {
                CargarListadoClientes();
            }
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            if (tabControlPrincipal.SelectedIndex == 0)
            {
                CargarListadoClientes();
            }
        }

        private void CargarListadoClientes()
        {
            List<dynamic> clientes = _clienteLogic.ObtenerClientesParaListado();
            dgvListadoClientes.DataSource = clientes;
        }

    }
}
