﻿using System;
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
        /// Función que se conecta con una api y devuelve un listado de personas.
        /// Pre:ninguna
        /// Post: si no lo consigue, devuelve un listado vacío.
        /// </summary>
        /// <returns></returns>
        public async static Task<List<clsPersona>> ListadoCompletoPersonasDAL()
        {
            //Pedimos la uri
            string miCadenaURL = clsMiConexión.uriBase();

            //Esto es para que el enrutamiento salga bien
            Uri miUri = new Uri($"{miCadenaURL}Personas");

            List<clsPersona> listadoPersonas = new List<clsPersona>();
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
                listadoPersonas = JsonConvert.DeserializeObject<List<clsPersona>>(textoJSONRespuesta);

            }

            client.Dispose();

            return listadoPersonas;
        }

    }
}
    
