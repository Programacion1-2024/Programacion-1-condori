using CDatos.Repositorios.Contracts;
using CEntidades.Entitis;
using CLogica.Contract;
using CLogica.Implementación;
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
    public partial class Cuenta : Form
    {
        private ICuentaLogic _cuentaLogic;
        private IClienteRepository _clienteRepository;
        private ICuentaRepository _cuentaRepository;

        public Cuenta(ICuentaLogic cuentaLogic, IClienteRepository clienteRepository, ICuentaRepository cuentaRepository)
        {
            InitializeComponent();
            _cuentaLogic = cuentaLogic;
            _clienteRepository = clienteRepository;
            _cuentaRepository = cuentaRepository;

            CargaCb();
            cb_Cliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Estado.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        public void CargaCb()
        {
            var Estado = _cuentaRepository.FindAll();
            cb_Estado.DataSource = EstadosCuenta.IdEstado.ToList() ;
            cb_Estado.DisplayMember = "Nombre";
            cb_Estado.ValueMember = "IdEstado";

            var Cliente = _clienteRepository.FindAll(); //lista de ciudades
            cb_Cliente.DataSource = Cliente;    // de donde saca la info
            cb_Cliente.DisplayMember = "Nombre";    // Propiedad que quieres mostrar en el ComboBox
            cb_Cliente.ValueMember = "IdCliente";

            cb_Cliente.SelectedIndex = -1;
            cb_Estado.SelectedIndex = -1;
        }

        public void CargarListadoCuentas()
        {
            List<dynamic> cuenta = _cuentaLogic.ObtenerCuentasParaListado();
            dgvCuenta.DataSource = cuenta;
        }
        private void tabControlPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Pestañas.SelectedIndex == 0)
            {
                CargarListadoCuentas();
            }
        }

        private void Cuenta_Load(object sender, EventArgs e)
        {
            if (Pestañas.SelectedIndex == 0)
            {
                CargarListadoCuentas();
            }
        }

        private void btn_Alta_Click(object sender, EventArgs e)
        {
            if (tb_Id.Text == "")
            {
                string NroCuenta = tb_NroCuenta.Text;
                decimal Saldo = decimal.Parse(tb_Saldo.Text);
                int IdEstado = (int)cb_Estado.SelectedValue;
                int IdCliente = (int)cb_Cliente.SelectedValue;
                if (_cuentaLogic.CuentaExiste(NroCuenta))
                {
                    MessageBox.Show("El número de cuenta ya existe. Intente con otro número.");
                    return;
                }
                try
                {
                    _cuentaLogic.AltaCuenta(NroCuenta, Saldo, IdEstado, IdCliente);
                    MessageBox.Show("Se ha creado la cuenta");

                    tb_Saldo.Clear();
                    tb_NroCuenta.Clear();
                    cb_Estado.SelectedIndex = -1;
                    cb_Cliente.SelectedIndex = -1;

                    CargarListadoCuentas();

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
                string IdCuenta = tb_Id.Text;
                string NroCuenta = tb_NroCuenta.Text;
                decimal Saldo = decimal.Parse(tb_Saldo.Text);
                int IdEstado = (int)cb_Estado.SelectedValue;
                int IdCliente = (int)cb_Cliente.SelectedValue;
                try
                {
                    _cuentaLogic.ActualizarCuenta(IdCuenta, NroCuenta, Saldo, IdEstado, IdCliente);
                    MessageBox.Show("Se ha modificado el cliente");

                    tb_Id.Clear();
                    tb_NroCuenta.Clear();
                    tb_Saldo.Clear();
                    cb_Estado.SelectedIndex = -1;
                    cb_Cliente.SelectedIndex = -1;

                    CargarListadoCuentas();
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
                int IdCuenta = int.Parse(tb_Id.Text);

                try
                {
                    CuentaBancaria cuentaNueva = _cuentaLogic.BuscarPorId(IdCuenta);
                    if (cuentaNueva != null)
                    {
                        tb_NroCuenta.Text = cuentaNueva.NroCuenta;
                        tb_Saldo.Text = cuentaNueva.Saldo.ToString();
                        cb_Estado.SelectedValue = cuentaNueva.IdEstado;
                        cb_Cliente.SelectedValue = cuentaNueva.IdCliente;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }
    }
}
