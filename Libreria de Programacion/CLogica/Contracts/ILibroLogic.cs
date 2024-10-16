using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface ILibroLogic
    {
        void AltaLibro(Libro libroNuevo);

        void ActualizarLibro(string ISBN, Libro libroActualizar);

        void EliminarLibro(string ISBN);
    }
}
