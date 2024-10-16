using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface IEditorialLogic
    {
        List<Editorial> ObtenerEditoriales();
        List<dynamic> ObtenerEditorialesParaListado();
        void AltaEditorial(string nombre, string direccion, string contacto);
        void ActualizarEditorial(string idEditorial, string nombre, string direccion, string contacto);
        void EliminarEditorial(string idEditorial);
        Editorial? BuscarEditorial(int idEditorial);
    }
}
