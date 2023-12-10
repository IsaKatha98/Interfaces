using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.HandlerDAL
{
    public static class clsHandlerDepartamentoDAL
    {
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
        }
    }
}
