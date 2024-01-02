using Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL.HandlerDAL
{
    public static class clsHandlerDepartamentoDAL
    {
        /*
        /// <summary>
        /// Función que hace un request de tipo delete de un Departamento.
        /// Esta función no la necesitamos para este CRUD por lo que simplemente la voy a comentar.
        /// </summary>
        /// <param name="idDepartamento"></param>
        /// <returns></returns>
        public async static Task<int> borrarDepartamentoDAL(int idDepartamento)
        {
            //Pedimos la uri
            string miCadenaURL = "";

            //Esto es para que el enrutamiento salga bien
            Uri miUri = new Uri($"{miCadenaURL}Departamentos/{idDepartamento}");

            int departamentoBorrado = 0;
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
                    //Guardamos el resultado en un JSON
                    textoJSONRespuesta = await client.GetStringAsync(miUri);

                    //Instalamos el NuGet de NewtonSoft para poder de-serializar el JSON.
                    departamentoBorrado = JsonConvert.DeserializeObject<int>(textoJSONRespuesta);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return departamentoBorrado;
        }*/

        /// <summary>
        /// Función que abre una tarea para insertar un Departamento nuevo.
        /// 
        ///TODO: ver como asigno el ID
        /// </summary>
        /// <param name="departamento"></param>
        /// <returns></returns>
        public static async Task<int> insertaDepartamentoDAL (clsDepartamento departamento)
        {
            HttpClient client = new HttpClient ();
            string datos;
            HttpContent contenido;
            int departamentoInsertado=0;

            //Pedimos la uri
            string miCadenaURL = "";

            //Esto es para que el enrutamiento salga bien
            Uri miUri = new Uri($"{miCadenaURL}Departamentos/");

            //Usaremos el estado de la respuesta para comprobar si se insertado bien el departamento.
            HttpResponseMessage res = new HttpResponseMessage();

            try
            {
                //Tenemos que serializar el objeto departamento.
                datos = JsonConvert.SerializeObject(departamento);

                contenido = new StringContent(datos, System.Text.Encoding.UTF8, "aplication/json");

                res = await client.PostAsync(miUri, contenido);

                if (res.IsSuccessStatusCode)
                {
                    departamentoInsertado = 1;
                }
            }
            catch (Exception ex) { throw ex; }

            //devolvemos el estado de la respuesta.
            return departamentoInsertado;

        }

        /// <summary>
        /// Función que actualiza el objeto departamento, pero no el id de ese objeto.
        /// </summary>
        /// <param name="departamento"></param>
        /// <returns></returns>
        public static async Task<int> actualizaDepartamentoDAL(clsDepartamento departamento)
        {

            HttpClient client = new HttpClient();
            string datos;
            HttpContent contenido;
            int departamentoActualizado=0;

            //Pedimos la uri
            string miCadenaURL = "";

            //Esto es para que el enrutamiento salga bien
            Uri miUri = new Uri($"{miCadenaURL}Departamentos/");

            //Usaremos el estado de la respuesta para comprobar si se insertado bien el departamento.
            HttpResponseMessage res = new HttpResponseMessage();

            try
            {
                //Tenemos que serializar el objeto departamento.
                datos = JsonConvert.SerializeObject(departamento);

                contenido = new StringContent(datos, System.Text.Encoding.UTF8, "aplication/json");

                res = await client.PutAsync(miUri, contenido);

                if (res.IsSuccessStatusCode)
                {
                    departamentoActualizado = 1;
                }
            }
            catch (Exception ex) { throw ex; }

            //devolvemos el estado de la respuesta.
            return departamentoActualizado;
        }
    }
}
