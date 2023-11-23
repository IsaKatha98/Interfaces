using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio01.Models.Entities;
namespace Ejercicio01.Models.DAL
{
    public static class clsListadoPersonasDAL
    {

        /// <summary>
    	/// Función que nos devuelve un listado de todas las personas
    	/// </summary>
    	/// <returns>Listado de personas</returns>
    	public static List<clsPersona> listadoPersonas()

        {
            List <clsPersona> listadoPersonas = new List<clsPersona>() {
            new clsPersona(1,"Fernando","Miguel"),
            new clsPersona(2,"Fernando","Miguel"),
            new clsPersona(3,"Fernando","Miguel"),
            new clsPersona(4, "Fernando","Miguel"),
            new clsPersona(5, "Fernando","Miguel"),
            new clsPersona(6, "Fernando","Miguel"),
            new clsPersona(7, "Fernando","Miguel"),
            new clsPersona(8, "Fernando","Miguel"),
            new clsPersona(9, "Fernando","Miguel"),
            new clsPersona(10, "Fernando","Miguel")



            };

            return listadoPersonas;

        }
    }
}
