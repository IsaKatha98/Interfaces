using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05.Models
{
    public static class clsListadoPersonasDAL
    {

        /// <summary>
    	/// Función que nos devuelve un listado de todas las personas
    	/// </summary>
    	/// <returns>Listado de personas</returns>
    	public static ObservableCollection<clsPersona> listadoPersonas()
        
        {
            ObservableCollection<clsPersona> listadoPersonas = new ObservableCollection<clsPersona>() {
            new clsPersona("Fernando","Miguel"),
            new clsPersona("Fernando","Miguel"),
            new clsPersona("Fernando","Miguel"),
            new clsPersona("Fernando","Miguel"),
            new clsPersona("Fernando","Miguel"),
            new clsPersona("Fernando","Miguel"),
            new clsPersona("Fernando","Miguel"),
            new clsPersona("Fernando","Miguel"),
            new clsPersona("Fernando","Miguel"),
            new clsPersona("Fernando","Miguel")
         


            };

            return listadoPersonas;
                
        }

    }
}
