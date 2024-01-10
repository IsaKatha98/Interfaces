using BL.HandlerBL;
using Ejercicio01.ViewModels.Utils;
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
    public class insertarDepartamentoVM: clsVMBase
    {
        #region atributos
        clsDepartamento departamentoNuevo;
        DelegateCommand cancelarCommand;//Esto lleva a otra vista
        DelegateCommand guardarCommand;
        #endregion

        #region constructores
        public insertarDepartamentoVM()
        {
            this.departamentoNuevo = new clsDepartamento();
            guardarCommand = new DelegateCommand(guardarCommandExecute, guardarCommandCanExecute);
            cancelarCommand = new DelegateCommand(cancelarCommandExecute, cancelarCommandCanExecute);
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
        public clsDepartamento DepartamentoNuevo
        {
            get { return departamentoNuevo; }
            set
            {
                departamentoNuevo = value;
                NotifyPropertyChanged("DepartamentoNuevo");
                cancelarCommand.RaiseCanExecuteChanged();
                guardarCommand.RaiseCanExecuteChanged();
            }
        }

        #endregion

        #region comandos
        private bool cancelarCommandCanExecute()
        {
            bool puedeCancelar = false;

            if (departamentoNuevo != null)
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
            await Shell.Current.Navigation.PopAsync();
        }

        private bool guardarCommandCanExecute()
        {

            bool puedeGuardar = false;

            if (departamentoNuevo != null)
            {
                puedeGuardar = true;

            }
            return puedeGuardar;
        }

        private async void guardarCommandExecute()
        {

            //Manda la persona a la bbdd.
            await clsHandlerDepartamentoBL.insertaDepartamentoBL(departamentoNuevo);

            //Aquí hay que comprobar si se ha insertado en la api

            //Esto navegará al listado.
            await Shell.Current.Navigation.PushAsync(new listadoDepartamentos()); //va el departamento seleccionado de param

        }

        #endregion


        #region métodos y funciones

        #endregion
    }
}
