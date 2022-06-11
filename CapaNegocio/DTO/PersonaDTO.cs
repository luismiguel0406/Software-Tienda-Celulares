using CapaDeDatos.CRUDS;
using CapaDeDatos.Models;
using System;
using System.Data;

namespace CapaNegocio.DTO
{
    public class PersonaDTO
    {
        public static DataTable MantenimientoPersona(Persona persona, int numQuery)
        {
            try
            {
                persona.numQuery = numQuery;
                personaDAO _personaInstancia = new personaDAO();
                var dt = _personaInstancia.Personas("USP_PERSONA", persona);
                return dt;
            }
            catch (Exception)
            {
                throw new Exception("Ha ocurrido un error, contacte un administrador");
            }

        }

    }
}
