using BL.ListadosBL;
using Ejercicio01.ViewModels.Utils;
using Ejercicio02.ViewModels.Utils;
using Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Viewmodels
{
    public class listadoPersonasVM: clsVMBase
    {
        #region atributos
        ObservableCollection<clsPersona> listaPersonasCompleto;
        ObservableCollection<clsPersona> listaPersonasMostradas;
        clsPersona personaSeleccionada;
        DelegateCommand buscarCommand;
        DelegateCommand eliminarCommand;
        DelegateCommand editarCommand;//esto es un comando si en realidad es un botón a otra vista.
        string textoBusqueda;

        #endregion

        #region constructores
        //En este constructor personaSeleccionada y textoBusqueda no aparecen porque son cosas que introduce el usuario.
      
        public  listadoPersonasVM(ObservableCollection<clsPersona>lista)
        {


            listaPersonasCompleto = lista;
            listaPersonasMostradas = listaPersonasCompleto;
            //buscarCommand = new DelegateCommand(buscarCommandExecute, buscarCommandCanExecute);
            //eliminarCommand = new DelegateCommand(eliminarCommandExecute, eliminarCommandCanExecute);
            //editarCommand = new DelegateCommand(editarCommandExecute, editarCommandCanExecute);

        }

        private static async Task<listadoPersonasVM> BuildViewModelAsync()
        {
     
            ObservableCollection<clsPersona> listaAsincronica = new ObservableCollection<clsPersona>( await clsListadoPersonasBL.listadoCompletoPersonasBL());

            return new listadoPersonasVM(listaAsincronica);     
        }

     


        #endregion

        #region propiedades
        public DelegateCommand BuscarCommand
        {
            get { return buscarCommand; }

        }

        public DelegateCommand EliminarCommand
        {
            get { return eliminarCommand; }

        }

        public DelegateCommand EditarCommand
        {
            get { return editarCommand; }

        }

        public ObservableCollection<clsPersona> ListaPersonas

        {
           
            get{   return listaPersonas; }

        }

       /* public clsPersona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set
            {
                personaSeleccionada = value;

                NotifyPropertyChanged("PersonaSeleccionada");
                eliminarCommand.RaiseCanExecuteChanged();


            }




        }

        public string TextoBusqueda
        {
            get { return textoBusqueda; }

            set
            {
                //Para que se active el botón, hay que poner el notifyPropertyChange aqui.
                textoBusqueda = value;
                NotifyPropertyChanged("textoBusqueda");
                buscarCommand.RaiseCanExecuteChanged();
            }

        }

        #endregion

        #region comandos
        private bool eliminarCommandCanExecute()
        {
            bool puedeEliminar = false;

            if (personaSeleccionada != null)
            {
                puedeEliminar = true;
            }

            return puedeEliminar;

        }

        private void eliminarCommandExecute()
        {
            listaPersonas.Remove(personaSeleccionada);


        }

        private bool buscarCommandCanExecute()
        {

            bool habilitarBuscar = false;

            if (!string.IsNullOrEmpty(textoBusqueda))
            {
                habilitarBuscar = true;

            }
            return habilitarBuscar;
        }

        private void buscarCommandExecute()
        {
            //TODO: LinQ 
            throw new NotImplementedException();
        }*/

        #endregion


        #region métodos y funciones
        
       

        

        
       


        
        #endregion
    }
}
