using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class clsMiConexión
    {
        /// <summary>
        /// Función que devuelve la cadena de la URI de mi API.
        /// 
        /// </summary>
        /// <returns>El enlace de la uri</returns>
        public static string uriBase()
        {
            return "https://crrudnervion.azurewebsites.net/api/";
        }
    }
}
