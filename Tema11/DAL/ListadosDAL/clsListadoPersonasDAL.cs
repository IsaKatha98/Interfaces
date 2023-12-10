using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Newtonsoft.Json;

namespace DAL.Listados
{
    public class clsListadoPersonasDAL
    {
        /// <summary>
        /// Método que se conecta con una api y devuelve un listado de personas.
        /// </summary>
        public async static Task<List<clsPersona>> ListadoCompletoPersonasDAL()
        {
            //Pedimos la uri
            string miCadenaURL = "";

            //Esto es para que el enrutamiento salga bien
            Uri miUri = new Uri($"{miCadenaURL}Personas");

            List<clsPersona> listadoPersonas = new List<clsPersona>();
            HttpClient client = new HttpClient();
            HttpResponseMessage message;
            string textoJSONRespuesta;

            try
            {
                //Hacemos el request del listado
                message = await client.GetAsync(miUri);

                //En caso de que salga bien
                if (message.IsSuccessStatusCode)
                {
                    //Guardamos el resultado en un JSON
                    textoJSONRespuesta = await client.GetStringAsync(miUri);

                    //Instalamos el NuGet de NewtonSoft para poder de-serializar el JSON.
                    listadoPersonas = JsonConvert.DeserializeObject<List<clsPersona>>(textoJSONRespuesta);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listadoPersonas;
        }

        /// <summary>
        /// Método que lee los detalles de una persona.
        /// 
        /// Pre: recibe un id de la persona.
        /// Post: 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async static Task<clsPersona> readDetailsPersonaDAL(int id)
        {

            //Pedimos la uri
            string miCadenaURL = "";

            //Esto es para que el enrutamiento salga bien
            Uri miUri = new Uri($"{miCadenaURL}Personas/{id}");

            clsPersona oPersona = new clsPersona();
            HttpClient client = new HttpClient();
            HttpResponseMessage message;
            string textoJSONRespuesta;

            try
            {
                //Hacemos el request del listado
                message = await client.GetAsync(miUri);

                //En caso de que salga bien
                if (message.IsSuccessStatusCode)
                {
                    //Guardamos el resultado en un JSON
                    textoJSONRespuesta = await client.GetStringAsync(miUri);

                    //Instalamos el NuGet de NewtonSoft para poder de-serializar el JSON.
                    oPersona = JsonConvert.DeserializeObject<clsPersona>(textoJSONRespuesta);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return oPersona;


        }

    }
}
    
