using DAL.HandlerDAL;
using Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.HandlerBL
{
    public static class clsHandlerPersonaBL
    {
        /// <summary>
        /// Función que llama a la DAL y delvuelve el número de filas afectadas al borrar
        /// una persona que recibe como parámetro y aplica las normas de negocio.
        /// Post: mi salida siempre será 0 o 1
        /// </summary>
        /// <param name="id">ID de la persona</param>
        /// <returns>el número de filas que se han borrado</returns>
        public async static Task<int> borrarPersonaDAL(int id)
        {
            //TODO:los domingos no se puede eliminar a ninguna persona
            DayOfWeek hoy=new DayOfWeek();
            DayOfWeek domingo= DayOfWeek.Sunday;
            int borrado = 0;

            if (hoy.Equals(domingo))
            {
                //TODO:mensaje en un Viewbag(?) de que hoy no se puede borrar a una persona porque es domingo.
            }
            else
            {
                borrado= await clsHandlerPersonaDAL.borrarPersonaDAL(id);
            }
            return borrado;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
        public async static Task<int> insertaPersonaBL (clsPersona persona)
        {
            return await clsHandlerPersonaDAL.insertaPersonaDAL(persona);
        }
        
        public async static Task<int> actualizaPersonaBL (clsPersona persona)
        {
            return await clsHandlerPersonaDAL.actuatializarPersonaDAL (persona);
        }

    }
}
