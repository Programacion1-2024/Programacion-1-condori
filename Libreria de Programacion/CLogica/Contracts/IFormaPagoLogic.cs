using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface IFormaPagoLogic
    {
        List<FormaPago> ObtenerFormasPago();
        List<dynamic> ObtenerFormasPagoParaListado();
        void AltaFormaPago(string descripcion);
        void ActualizarFormaPago(int idFormaPago, string descripcion);
        void EliminarFormaPago(int idFormaPago);
        FormaPago? BuscarFormaPago(int idFormaPago);

    }
}
