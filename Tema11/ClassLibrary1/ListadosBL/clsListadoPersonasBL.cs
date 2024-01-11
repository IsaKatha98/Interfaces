using DAL.Listados;
using Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ListadosBL
{
    public static class clsListadoPersonasBL
    {
        /// <summary>
        /// Función que llama a la función de listado de personas de la capa DAL
        /// y devuelve un listado de personas. Aplicamos la regla de nuestro negocio.
        /// </summary>
        public static async Task<List<clsPersona>> listadoCompletoPersonasBL()
        {
            //llamamos a la lista de personas de la capa DAL
            List<clsPersona> listadoPersonasBL =await clsListadoPersonasDAL.ListadoCompletoPersonasDAL();
            List<clsPersona> listadoPersonasEnviado = new List<clsPersona>();
            DateTime ahora= DateTime.Now;

            foreach (clsPersona persona in listadoPersonasBL)
            {

                int edad = ahora.Year - persona.FechaNac.Year;
                if (edad>=18)
                {
                    listadoPersonasEnviado.Add(persona);
                }

            }




            
            return listadoPersonasEnviado;
        }

      
    }
}
