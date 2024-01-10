using Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL.HandlerDAL
{
    public static class clsHandlerPersonaDAL
    {
        
        public async static Task<int> borrarPersonaDAL(int id)
        {
            //Pedimos la uri
            string miCadenaURL = clsMiConexión.uriBase();

            //Esto es para que el enrutamiento salga bien
            Uri miUri = new Uri($"{miCadenaURL}Personas/{id}");

            int personaBorrada=0;
            HttpClient client = new HttpClient();
            HttpResponseMessage message;
            string textoJSONRespuesta;

            try
            {
                //Hacemos el request del listado
                message = await client.DeleteAsync(miUri);

                //En caso de que salga bien
                if (message.IsSuccessStatusCode)
                {
                    //Esto me da error, así que lo voy a hacer un return a mano.
                    personaBorrada = 1;

                    //Guardamos el resultado en un JSON
                    //textoJSONRespuesta = await client.GetStringAsync(miUri);

                    //Instalamos el NuGet de NewtonSoft para poder de-serializar el JSON.
                    //departamentoBorrado = JsonConvert.DeserializeObject<int>(textoJSONRespuesta);

                }
                client.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return personaBorrada;
        }


        /// <summary>
        /// Función que abre una tarea para insertar una persona nueva.
        /// 
        ///TODO: ver como asigno el ID
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
        public static async Task<int> insertaPersonaDAL(clsPersona persona)
        {
            HttpClient client = new HttpClient();
            string datos;
            HttpContent contenido;
            int personaCreada=0;

            //Pedimos la uri
            string miCadenaURL = clsMiConexión.uriBase();

            //Esto es para que el enrutamiento salga bien
            Uri miUri = new Uri($"{miCadenaURL}Personas/");

            //Usaremos el estado de la respuesta para comprobar si se insertado bien el departamento.
            HttpResponseMessage res = new HttpResponseMessage();

            try
            {
                //Tenemos que serializar el objeto departamento.
                datos = JsonConvert.SerializeObject(persona);

                datos = datos.ToLower();//lo pasamos a minúscula

                contenido = new StringContent(datos, Encoding.UTF8, "application/json");

                res = await client.PostAsync(miUri, contenido);

                //Si ha ido bien, confirmamos que se ha creado la persona.
                if (res.IsSuccessStatusCode)
                {
                    personaCreada = 1;
                
                }

                client.Dispose();
            }
            catch (Exception ex) { throw ex; }

            //devolvemos el estado de la respuesta.
            return personaCreada;

        }

        /// <summary>
        /// Función que actualiza el objeto persona, pero no el id de ese objeto.
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
        public static async Task<int> actuatializarPersonaDAL(clsPersona persona)
        {

            HttpClient client = new HttpClient();
            string datos;
            HttpContent contenido;
            int personaActualizada =0;

            //Pedimos la uri
            string miCadenaURL = clsMiConexión.uriBase();

            //Esto es para que el enrutamiento salga bien
            Uri miUri = new Uri($"{miCadenaURL}Personas/");

            //Usaremos el estado de la respuesta para comprobar si se insertado bien el departamento.
            HttpResponseMessage res = new HttpResponseMessage();

            try
            {
                //Tenemos que serializar el objeto departamento.
                datos = JsonConvert.SerializeObject(persona);

                contenido = new StringContent(datos, Encoding.UTF8, "application/json"); //me pasa lo mismo que en el handler de departamentos

                res = await client.PutAsync(miUri, contenido);

            res= await client.PutAsync(miUri, contenido);


                //Si ha ido bien, confirmamos que se ha actualizado la persona.
                if (res.IsSuccessStatusCode)
                {
                    personaActualizada = 1;

                }

                client.Dispose();
            }
            catch (Exception ex) { throw ex; }

            //devolvemos el estado de la respuesta.
            return personaActualizada;
        }
    }
}
