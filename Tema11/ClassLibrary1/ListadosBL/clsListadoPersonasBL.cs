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
        /// Método que llama a la función de listado de personas de la capa DAL
        /// y devuelve un listado de personas. Hace un filtrado según si el día
        /// actual es viernes o sábado. En caso de que sí, solo muestra las personas
        /// mayores de 18.
        /// </summary>
        public async static Task<List<clsPersona>> ListadoCompletoPersonasBL()
        {
            //llamamos a la lista de personas de la capa DAL
            List<clsPersona> listadosPersonasBL =await clsListadoPersonasDAL.ListadoCompletoPersonasDAL();
            //TODO:Aquí hay que hacer un if-else para mostrar únicamente a las personas mayores de 18.
            
            return listadosPersonasBL;
        }

        /// <summary>
        /// Método que lee los detalles de una persona,
        /// llamando a la función de la capa DAL
        /// 
        /// Pre: recibe un id de la persona.
        /// Post: 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async static Task<clsPersona> readDetailsPersonaDAL(int id)
        {
            //Ponemos await porque está función deberá esperar que la capa DAL haga el request
            clsPersona oPersona= await clsListadoPersonasDAL.readDetailsPersonaDAL(id);

            return oPersona;


        }
    }
}
