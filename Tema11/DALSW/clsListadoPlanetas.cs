using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesSW;

namespace DALSW
{
    public class clsListadoPlanetas
    {
        /// <summary>
        /// Método que lee los detalles de una persona.
        /// 
        /// Pre: recibe un id de la persona.
        /// Post: 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async static Task<string> nombrePlanetaById(int idPersonaje)
        {

            //Pedimos la uri
            string miCadenaURL = "";

            //Esto es para que el enrutamiento salga bien
            Uri miUri = new Uri($"{miCadenaURL}planets/{idPersonaje}");

            string nombrePlaneta;
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
