using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface IGeneroLogic
    {
        List<Genero> ObtenerGeneros();
        List<dynamic> ObtenerGenerosParaListado();
        void AltaGenero(string nombre, string descripcion);
        void ActualizarGenero(int idGenero, string nombre, string descripcion);
        void EliminarGenero(int idGenero);
        Genero? BuscarGenero(int idGenero);

    }
}
