using CEntidades.Entidades;
using CLogica.Contracts;
using CLogica.Implementations;

namespace CPresentacion
{
    public partial class ABMAutor : Form
    {
        private IAutorLogic _autorLogic;


        public ABMAutor(IAutorLogic autorLogic)
        {
            InitializeComponent();
            _autorLogic = autorLogic;
        }

        private void tabControlPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlPrincipal.SelectedIndex == 0)
            {
                CargarListadoAutores();
            }
        }

        private void ABMAutor_Load(object sender, EventArgs e)
        {
            if (tabControlPrincipal.SelectedIndex == 0)
            {
                CargarListadoAutores();
            }
        }

        private void CargarListadoAutores()
        {
            List<dynamic> autors = _autorLogic.ObtenerAutoresParaListado();
            dgvListadoAutores.DataSource = autors;
        }

        private void btnGuardarModificacion_Click(object sender, EventArgs e)
        {
            if (tbIdAutor.Text != "")
            {
                string idAutor = tbIdAutor.Text;
                string nombre = tbNombreModificacion.Text;
                string apellido = tbApellidoModificacion.Text;
                string nacionalidad = tbNacionalidadModificacion.Text;
                string email = tbEmailModificacion.Text;
                string telefono = tbTelefonoModificacion.Text;
                string biografia = tbBiografiaModificacion.Text;
                try
                {
                    _autorLogic.ActualizacionAutor(idAutor, nombre, apellido, nacionalidad, email, telefono, biografia);
                    MessageBox.Show("El autor se ha registrado con éxito.");

                    tbIdAutor.Clear();
                    tbNombreModificacion.Clear();
                    tbApellidoModificacion.Clear();
                    tbNacionalidadModificacion.Clear();
                    tbEmailModificacion.Clear();
                    tbTelefonoModificacion.Clear();
                    tbBiografiaModificacion.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            {
                if (tbIdAutor.Text != "")
                {
                    int idAutor = int.Parse(tbIdAutor.Text);

                    // Llamar a la lógica para buscar el autor
                    try
                    {
                        Autor? autor = _autorLogic.BuscarAutor(idAutor);// _autorLogic es la capa lógica donde está el método BuscarId
                        if (autor != null)
                        {
                            // Autocompletar los TextBox con los datos del autor
                            tbNombreModificacion.Text = autor.Persona.Nombre;
                            tbApellidoModificacion.Text = autor.Persona.Apellido;
                            tbTelefonoModificacion.Text = autor.Persona.Telefono;
                            tbEmailModificacion.Text = autor.Persona.Email;
                            tbNacionalidadModificacion.Text = autor.Persona.Nacionalidad;
                            tbBiografiaModificacion.Text = autor.Biografia;

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
            }
        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            if (tbIdAutor.Text == "")
            {
                string nombre = tbNombreModificacion.Text;
                string apellido = tbApellidoModificacion.Text;
                string nacionalidad = tbNacionalidadModificacion.Text;
                string email = tbEmailModificacion.Text;
                string telefono = tbTelefonoModificacion.Text;
                string biografia = tbBiografiaModificacion.Text;
                try
                {
                    _autorLogic.AltaAutor(nombre, apellido, nacionalidad, email, telefono, biografia);
                    MessageBox.Show("El autor se ha actualizado con éxito.");

                    tbIdAutor.Clear();
                    tbNombreModificacion.Clear();
                    tbApellidoModificacion.Clear();
                    tbNacionalidadModificacion.Clear();
                    tbEmailModificacion.Clear();
                    tbTelefonoModificacion.Clear();
                    tbBiografiaModificacion.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (tbIdAutor.Text != "")
            {
                string idAutor = tbIdAutor.Text;
                try
                {
                    _autorLogic.EliminarAutor(idAutor);
                    MessageBox.Show("El autor se ha eliminado con éxito.");

                    tbIdAutor.Clear();
                    tbNombreModificacion.Clear();
                    tbApellidoModificacion.Clear();
                    tbNacionalidadModificacion.Clear();
                    tbEmailModificacion.Clear();
                    tbTelefonoModificacion.Clear();
                    tbBiografiaModificacion.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
