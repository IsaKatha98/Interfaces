using BL.ListadosBL;
using Ejercicio01.ViewModels.Utils;
using Ejercicio02.ViewModels.Utils;
using Entities;
using Microsoft.VisualBasic;
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
        ObservableCollection<clsPersona> listaPersonas;
      
        clsPersona personaSeleccionada;
        DelegateCommand buscarCommand;
        DelegateCommand eliminarCommand;
        DelegateCommand editarCommand;//esto es un comando si en realidad es un botón a otra vista.
        DelegateCommand crearCommand;//Esto lleva a otra vista
        string textoBusqueda;

        #endregion

        #region constructores
        //En este constructor personaSeleccionada y textoBusqueda no aparecen porque son cosas que introduce el usuario.
      
        public  listadoPersonasVM()
        {
            cargarLista();       
            buscarCommand = new DelegateCommand(buscarCommandExecute, buscarCommandCanExecute);
            eliminarCommand = new DelegateCommand(eliminarCommandExecute, eliminarCommandCanExecute);
            editarCommand = new DelegateCommand(editarCommandExecute, editarCommandCanExecute);
            crearCommand = new DelegateCommand(crearCommandExecute, crearCommandCanExecute);

        }

        private async void cargarLista()
        {
            listaPersonas = new ObservableCollection<clsPersona>( await clsListadoPersonasBL.listadoCompletoPersonasBL());

            //Notificamos que ha habido cambios en la propiedad ListaPersonas, para que la cargue la vista.
            NotifyPropertyChanged("ListaPersonas");
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

        public clsPersona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set
            {
                personaSeleccionada = value;

                NotifyPropertyChanged("PersonaSeleccionada");
                eliminarCommand.RaiseCanExecuteChanged();
                editarCommand.RaiseCanExecuteChanged();
                crearCommand.RaiseCanExecuteChanged();
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

                //TODO: lo suyo sería que este botón se pusiera rojo.
                
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
        }

        private bool editarCommandCanExecute()
        {
            bool puedeEditar = false;

            if (personaSeleccionada != null)
            {
                puedeEditar = true;

               

            }

            return puedeEditar;

        }

        private void editarCommandExecute()
        {
            //Aquí nos lleva a otra vista
            Shell.Current.GoToAsync("//appshell/editarpersona");


        }

        private bool crearCommandCanExecute()
        {
            bool puedeCrear = true;

            if (personaSeleccionada != null)
            {
                puedeCrear = false;
            }

            return puedeCrear;

        }

        private void crearCommandExecute()
        {
            //Aquí nos lleva a otra vista
            Shell.Current.GoToAsync("//appshell/crearpersona");


        }

        #endregion


        #region métodos y funciones

        #endregion
    }
}
