using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface ICopiaLogic
    {
        List<dynamic> ObtenerCopiasParaListado();
        List<Copia> ObtenerCopias();
        List<Copia> ObtenerCopiasConLibro();
        List<Copia> ObtenerCopiasConPrestamos();
        void AltaCopia(float precioPrestamo, Libro libro);
        void ActualizarCopia(int idCopia, float nuevoPrecioPrestamo, Libro nuevoLibro);
        void EliminarCopia(int idCopia);
        Copia? ObtenerCopiaPorId(int idCopia);
    }
}
