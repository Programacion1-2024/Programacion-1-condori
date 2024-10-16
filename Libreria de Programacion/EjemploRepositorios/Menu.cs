using CDatos.Contexts;
using CDatos.Repositories.Contracts;
using CDatos.Repositories;
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
using CPresentacion.Empleado;
using CPresentacion.Cliente;

namespace CPresentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            // Crear la instancia del contexto de la base de datos
            LibreriaContext context = new LibreriaContext();

            // Crear las instancias de los repositorios
            IAutorRepository autorRepository = new AutorRepository(context);
            IPersonaRepository personaRepository = new PersonaRepository(context); // Si no existe, crea la implementación
            // Crear la lógica de negocio para Persona
            IPersonaLogic personaLogic = new PersonaLogic(personaRepository);

            // Pasar las instancias al constructor de AutorLogic Form
            AutorLogic autorLogic = new AutorLogic(autorRepository, personaLogic);

            // Crear el formulario ABMAutor y pasar la lógica
            ABMAutor autorForm = new ABMAutor(autorLogic);
            autorForm.ShowDialog();

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            // Crear la instancia del contexto de la base de datos
            LibreriaContext context = new LibreriaContext();

            // Crear las instancias de los repositorios
            IEmpleadoRepository empleadoRepository = new EmpleadoRepository(context);
            IPersonaRepository personaRepository = new PersonaRepository(context); // Si no existe, crea la implementación
            // Crear la lógica de negocio para Persona
            IPersonaLogic personaLogic = new PersonaLogic(personaRepository);

            // Pasar las instancias al constructor de AutorLogic Form
            EmpleadoLogic empleadoLogic = new EmpleadoLogic(empleadoRepository, personaLogic);

            // Crear el formulario ABMAutor y pasar la lógica
            FrmEmpleado empleadoForm = new FrmEmpleado(empleadoLogic);
            empleadoForm.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            LibreriaContext context = new LibreriaContext();

            // Crear las instancias de los repositorios
            IClienteRepository clienteRepository = new ClienteRepository(context);
            IPersonaRepository personaRepository = new PersonaRepository(context); // Si no existe, crea la implementación
            // Crear la lógica de negocio para Persona
            IPersonaLogic personaLogic = new PersonaLogic(personaRepository);

            // Pasar las instancias al constructor de AutorLogic Form
            ClienteLogic clienteLogic = new ClienteLogic(clienteRepository, personaLogic);

            // Crear el formulario ABMAutor y pasar la lógica
            FrmCliente clienteForm = new FrmCliente(clienteLogic);
            clienteForm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
