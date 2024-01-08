using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.HandlerBL;
using BL.ListadosBL;
using Ejercicio01.ViewModels.Utils;
using Ejercicio02.ViewModels.Utils;
using Entities;

namespace Ejercicio02.Viewmodels
{
    public class insertarPersonaVM:clsVMBase
    {
        #region atributos
        ObservableCollection<clsDepartamento> listaDepartamentos = new ObservableCollection<clsDepartamento>();
        clsDepartamento departamentoSeleccionado;
        clsPersona nuevaPersona;
        DelegateCommand cancelarCommand;//Esto lleva a otra vista
        DelegateCommand guardarCommand;
        #endregion

        #region constructores
       

        public insertarPersonaVM()
        {
           //cargamos la lista de los departamentos
            cargarLista();

            guardarCommand = new DelegateCommand(guardarCommandExecute, guardarCommandCanExecute);
            cancelarCommand = new DelegateCommand(cancelarCommandExecute, cancelarCommandCanExecute);
            

        }

        private async void cargarLista()
        {

            //Nos traemos la lista de departamentos.
            listaDepartamentos = new ObservableCollection<clsDepartamento>(await clsListadoDepartamentoBL.ListadoCompletoDepartamentosBL());

            //Notificamos que ha habido cambios en la propiedad ListaPersonas, para que la cargue la vista.
            NotifyPropertyChanged("ListaDepartamentos");
        }

        #endregion

        #region propiedades
        public DelegateCommand GuardarCommand
        {
            get { return guardarCommand; }

        }

        public DelegateCommand CancelarCommand
        {
            get { return cancelarCommand; }

        }

        public ObservableCollection<clsDepartamento> ListaDepartamentos
        {
            get { return listaDepartamentos; }
        }

        public clsDepartamento DepartamentoSeleccionado
        {
            get { return departamentoSeleccionado; }
            set
            {
                departamentoSeleccionado = value;
                NotifyPropertyChanged("DepartamentoSeleccionado");
            }
        }

        public clsPersona NuevaPersona
        {
            get { return nuevaPersona; }
            set
            {
                nuevaPersona = value;

                NotifyPropertyChanged("nuevaPersona");
                cancelarCommand.RaiseCanExecuteChanged();
                guardarCommand.RaiseCanExecuteChanged();
               
            }
        }

        #endregion

        #region comandos
        private bool cancelarCommandCanExecute()
        {
            bool puedeCancelar = false;

            if (nuevaPersona != null)
            {
                puedeCancelar = true;

                //TODO: lo suyo sería que este botón se pusiera rojo.

            }

            return puedeCancelar;

        }
        /// <summary>
        /// Método que cancela la inserción de una persona.
        /// </summary>
        private async void cancelarCommandExecute()
        {
            //Esto navegará al listado de personas.
            await Shell.Current.GoToAsync("//listadoPersonas");
        }

        private bool guardarCommandCanExecute()
        {

            bool puedeGuardar = false;

            if (nuevaPersona!=null)
            {
                puedeGuardar = true;

            }
            return puedeGuardar;
        }

        private async void guardarCommandExecute()
        {

            //Manda la persona a la bbdd.
            await clsHandlerPersonaBL.insertaPersonaBL(nuevaPersona);

            //Esto navegará al listado de personas.
            await Shell.Current.GoToAsync("//listadoPersonas");
        }

        #endregion


        #region métodos y funciones

        #endregion
    }
}
