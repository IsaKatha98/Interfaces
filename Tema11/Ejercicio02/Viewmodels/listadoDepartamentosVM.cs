using BL.HandlerBL;
using BL.ListadosBL;
using Ejercicio01.ViewModels.Utils;
using Ejercicio02.Models;
using Ejercicio02.ViewModels.Utils;
using Ejercicio02.Views;
using Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Viewmodels
{
    public class listadoDepartamentosVM: clsVMBase
    {
        #region atributos
        ObservableCollection<clsDepartamento> listaDept = new ObservableCollection<clsDepartamento>();
        clsDepartamento departamentoSeleccionado;
        DelegateCommand buscarCommand;
        DelegateCommand eliminarCommand;
        DelegateCommand editarCommand;//esto es un comando si en realidad es un botón a otra vista.
        DelegateCommand crearCommand;//Esto lleva a otra vista
        string textoBusqueda;

        #endregion

        #region constructores
        //En este constructor personaSeleccionada y textoBusqueda no aparecen porque son cosas que introduce el usuario.

        public listadoDepartamentosVM()
        {
            cargarLista();

            buscarCommand = new DelegateCommand(buscarCommandExecute, buscarCommandCanExecute);
            eliminarCommand = new DelegateCommand(eliminarCommandExecute, eliminarCommandCanExecute);
            editarCommand = new DelegateCommand(editarCommandExecute, editarCommandCanExecute);
            crearCommand = new DelegateCommand(crearCommandExecute);

        }

        private async void cargarLista()
        {
            //Nos traemos la lista
            listaDept = new ObservableCollection<clsDepartamento>(await clsListadoDepartamentoBL.ListadoCompletoDepartamentosBL());

            //Notificamos que ha habido cambios en la propiedad ListaPersonas, para que la cargue la vista.
            NotifyPropertyChanged("ListaDept");
        }

        #endregion

        #region propiedades
        public DelegateCommand CrearCommand
        {
            get { return crearCommand; }

        }
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

        public ObservableCollection<clsDepartamento> ListaDept

        {
            get { return listaDept; }

        }


        public clsDepartamento DepartamentoSeleccionado
        {
            get { return departamentoSeleccionado; }
            set
            {
                departamentoSeleccionado = value;

                NotifyPropertyChanged("DepartamentoSeleccionado");
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

            if (departamentoSeleccionado != null)
            {
                puedeEliminar = true;

                //TODO: lo suyo sería que este botón se pusiera rojo.

            }

            return puedeEliminar;

        }

        private async void eliminarCommandExecute()
        {

            await clsHandlerDepartamentoBL.borraDepartamentoBL(departamentoSeleccionado.Id);

            //Aquí nos lleva a otra vista
            await Shell.Current.Navigation.PushAsync(new listadoDepartamentos());




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
            //TODO: esto hay que mejorarlo
            ObservableCollection<clsDepartamento> listaDeptEncontrados = new ObservableCollection<clsDepartamento>(listaDept.Where(dept =>dept.Nombre.Contains(textoBusqueda)).ToList());

            //notificamos el cambio.
            NotifyPropertyChanged("ListaDept");

            //Igualamos las listas.
            listaDept = listaDeptEncontrados;

            
        }

        private bool editarCommandCanExecute()
        {
            bool puedeEditar = false;

            if (departamentoSeleccionado != null)
            {
                puedeEditar = true;

            }

            return puedeEditar;

        }

        private async void editarCommandExecute()
        {

            
            //Aquí nos lleva a otra vista
            await Shell.Current.Navigation.PushAsync(new EditarDepartamento(departamentoSeleccionado));

           

        }

        private async void crearCommandExecute()
        {
            //Aquí nos lleva a otra vista
            await Shell.Current.Navigation.PushAsync(new InsertaDepartamento());

        }

        #endregion

        #region métodos y funciones

        //on appearing. evento de código behind. 
        //El evento está en el vm.

        #endregion
    }
}
