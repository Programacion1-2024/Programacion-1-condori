using CEntidades.Entidades;
using CLogica.Contracts;
using CLogica.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CPresentacion.Empleado
{
    public partial class FrmEmpleado : Form
    {
        private IEmpleadoLogic _empleadoLogic;
        public FrmEmpleado(IEmpleadoLogic empleadoLogic)
        {
            InitializeComponent();
            cbCargo.DataSource = new List<string>(cargosYSueldos.Keys);

            // Asignar el evento SelectedIndexChanged al ComboBox
            cbCargo.SelectedIndexChanged += cbCargo_SelectedIndexChanged;
           
            _empleadoLogic = empleadoLogic;
            // Inyectamos la lógica de negocio
        }

        private void tabControlPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlPrincipal.SelectedIndex == 0)
            {
                CargarListadoEmpleados();
            }
        }

        private void FrmEmppleado(object sender, EventArgs e)
        {
            if (tabControlPrincipal.SelectedIndex == 0)
            {
                CargarListadoEmpleados();
            }
        }

        private void CargarListadoEmpleados()
        {
            List<dynamic> empleados = _empleadoLogic.ObtenerEmpleadosParaListado();
            dgvListadoEmpleados.DataSource = empleados;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tbIdEmpleado.Text != "")
            {
                string idEmpleado = tbIdEmpleado.Text;
                string nombre = tbNombreModificacion.Text;
                string apellido = tbApellidoModificacion.Text;
                string documento = tbDocumentoModificacion.Text;
                string email = tbEmailModificacion.Text;
                string telefono = tbTelefonoModificacion.Text;
                string cargo = cbCargo.SelectedItem.ToString();
                string sueldo = tbSueldoModificacion.Text;
                try
                {
                    _empleadoLogic.ActualizarEmpleado(idEmpleado, nombre, apellido, documento, email, telefono, cargo, sueldo);
                    MessageBox.Show("El Empleado se ha actualizado con éxito.");

                    tbIdEmpleado.Clear();
                    tbNombreModificacion.Clear();
                    tbApellidoModificacion.Clear();
                    tbDocumentoModificacion.Clear();
                    tbEmailModificacion.Clear();
                    tbTelefonoModificacion.Clear();
                    cargo = cbCargo.SelectedItem.ToString();
                    tbSueldoModificacion.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (tbIdEmpleado.Text != "")
            {
                string idEmpleado = tbIdEmpleado.Text;
                try
                {
                    _empleadoLogic.EliminarEmpleado(idEmpleado);
                    MessageBox.Show("El empleado se ha eliminado con éxito.");

                    tbIdEmpleado.Clear();
                    tbNombreModificacion.Clear();
                    tbApellidoModificacion.Clear();
                    tbDocumentoModificacion.Clear();
                    tbEmailModificacion.Clear();
                    tbTelefonoModificacion.Clear();
                    cbCargo.SelectedIndex = -1;
                    tbSueldoModificacion.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnGuardarAlta_Click_1(object sender, EventArgs e)
        {
            string idEmpleado = tbIdEmpleado.Text;
            string nombre = tbNombreModificacion.Text;
            string apellido = tbApellidoModificacion.Text;
            string documento = tbDocumentoModificacion.Text;
            string email = tbEmailModificacion.Text;
            string telefono = tbTelefonoModificacion.Text;
            string cargo = cbCargo.SelectedItem.ToString();
            string sueldo = tbSueldoModificacion.Text;
            try
            {
                _empleadoLogic.AltaEmpleado(nombre, apellido, documento, email, telefono, cargo, sueldo);
                MessageBox.Show("El Empleado se ha registrado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private Dictionary<string, decimal> cargosYSueldos = new Dictionary<string, decimal>()
        {
            { "Gerente", 5000 },
            { "Supervisor", 3500 },
            { "Asistente", 2000 },
            { "Operario", 1500 }
        };
        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cargoSeleccionado = cbCargo.SelectedItem.ToString();

            // Buscar el sueldo correspondiente al cargo seleccionado y mostrarlo en el TextBox
            if (cargosYSueldos.TryGetValue(cargoSeleccionado, out decimal sueldo))
            {
                tbSueldoModificacion.Text = sueldo.ToString("F2"); // Mostrar el sueldo formateado con dos decimales
            }
        }
    }
}
