using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesSW;
using Newtonsoft.Json;

namespace DALSW
{
    public class clsListadoPersonajes
    {
        /// <summary>
        /// Función que se conecta con una api y devuelve un listado de personaje.
        /// Pre:ninguna
        /// Post: si no lo consigue, devuelve un listado vacío.
        /// </summary>
        /// <returns></returns>
        public async static Task<List<clsPersonaje>> ListadoCompletoPersonajesDALSW()
        {
            //Pedimos la uri
            string miCadenaURL = clsMiConexiónSW.uriBase();

            //Esto es para que el enrutamiento salga bien
            Uri miUri = new Uri($"{miCadenaURL}Personas");

            List<clsPersonaje> listadoPersonajes = new List<clsPersonaje>();
            HttpClient client = new HttpClient();
            HttpResponseMessage message;
            string textoJSONRespuesta;


            //Hacemos el request del listado
            message = await client.GetAsync(miUri);

            //En caso de que salga bien
            if (message.IsSuccessStatusCode)
            {
                //Guardamos el resultado en un JSON
                textoJSONRespuesta = await client.GetStringAsync(miUri);

                //Instalamos el NuGet de NewtonSoft para poder de-serializar el JSON.
                listadoPersonajes = JsonConvert.DeserializeObject<List<clsPersonaje>>(textoJSONRespuesta);

            }

            return listadoPersonajes;
        }

        /// <summary>
        /// Método que lee los detalles de una personaje.
        /// 
        /// Pre: recibe un id del personaje.
        /// Post: 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async static Task<clsPersonaje> readDetailsPersonajeDAL(int id)
        {

            //Pedimos la uri
            string miCadenaURL = "";

            //Esto es para que el enrutamiento salga bien
            Uri miUri = new Uri($"{miCadenaURL}Personas/{id}");

            clsPersonaje oPersonaje = new clsPersonaje();
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
                    oPersonaje = JsonConvert.DeserializeObject<clsPersonaje>(textoJSONRespuesta);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return oPersonaje;
        }

        }
    }
