using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio01.Models.Entities;
using Ejercicio01.ViewModels.Utils;
using Ejercicio01.Models.DAL;

namespace Ejercicio01.ViewModels
{
    public class MainPageVM:clsVMBase
    
    {
        #region atributos
        DelegateCommand buscarComand;
        DelegateCommand eliminarComand;
        List<clsPersona> listadoPersonas;
        clsPersona personaSeleccionada;
        string textoBusqueda;
        #endregion

        #region constructores

        public MainPageVM() {

            listadoPersonas = clsListadoPersonasDAL.listadoPersonas();

            buscarComand = new DelegateCommand(buscarCanExecute, buscarComandCanExecute);

            eliminarComand = new DelegateCommand(eliminarComandExecute, eliminarComandCanExecute);

        
        
        }

        #endregion

        #region propiedades

        public DelegateCommand BuscarComand
        {
            get { return buscarComand; }
            
        }

        public DelegateCommand EliminarComand
        {
            get { return eliminarComand; }

        }

        public List<clsPersona> ListadoPersonas

        {
            get { return listadoPersonas; }

        }

        public clsPersona PersonaSeleccionada
        {
            set { personaSeleccionada = value; }


        }

        public string TextoBusqueda
        {
            get { return textoBusqueda; } set {  textoBusqueda = value;}

        }
           

        #endregion
        #region comandos

        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <returns></returns>
        private bool eliminarComandCanExecute()
        {
            bool puedeEliminar = false;

            if (personaSeleccionada != null)
            {
                puedeEliminar= true;
            }

            return puedeEliminar;

        }

        private void eliminarComandExecute()
        {
            listadoPersonas.Remove(personaSeleccionada);
            NotifyPropertyChanged("ListadoPersonas");
        }

        private bool buscarComandCanExecute()
        {

            bool habilitarBuscar = false;

            if (!string.IsNullOrEmpty(textoBusqueda))
            {
                habilitarBuscar = true;

            }

            return habilitarBuscar;
        }

        #endregion

        #region métodos y funciones

        

        #endregion



    }
}
