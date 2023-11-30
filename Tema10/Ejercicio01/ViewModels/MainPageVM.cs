using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio01.Models.Entities;
using Ejercicio01.ViewModels.Utils;
using Ejercicio01.Models.DAL;
using Ejercicio01.Views;
using System.Collections.ObjectModel;

namespace Ejercicio01.ViewModels
{
    public class MainPageVM:clsVMBase
    
    {
        #region atributos
        DelegateCommand buscarComand;
        DelegateCommand eliminarComand;
        ObservableCollection<clsPersona> listadoPersonas;
        clsPersona personaSeleccionada;
        string textoBusqueda;
        #endregion

        #region constructores

        public MainPageVM() {

            listadoPersonas = new ObservableCollection<clsPersona>(clsListadoPersonasDAL.listadoPersonas());

            buscarComand = new DelegateCommand(buscarComandExecute, buscarComandCanExecute);

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

        public ObservableCollection<clsPersona> ListadoPersonas

        {
            get { return listadoPersonas; }

        }

        public clsPersona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set { personaSeleccionada = value;

                NotifyPropertyChanged("PersonaSeleccionada");
                eliminarComand.RaiseCanExecuteChanged();
               
               
            }

           


        }

        public string TextoBusqueda
        {
            get { return textoBusqueda; } 
            
            set {  
                //Para que se active el botón, hay que poner el notifyPropertyChange aqui.
                textoBusqueda = value;
                NotifyPropertyChanged("textoBusqueda");
                buscarComand.RaiseCanExecuteChanged();
            }

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

        private void buscarComandExecute()
        {
           //TODO: LinQ 
           throw new NotImplementedException();
        }

        #endregion

        #region métodos y funciones

       

        #endregion



    }
}
