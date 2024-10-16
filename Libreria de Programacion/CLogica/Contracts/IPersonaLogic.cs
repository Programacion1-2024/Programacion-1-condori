using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface IPersonaLogic
    {
        Persona AltaPersona(Persona persona);

        void ActualizarPersona(Persona personaActualizar);

        void EliminarPersona(string documento);


    }
}
