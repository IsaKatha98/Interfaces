using BL.HandlerBL;
using Ejercicio01.ViewModels.Utils;
using Ejercicio02.ViewModels.Utils;
using Ejercicio02.Views;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Viewmodels
{
    public class editarDepartamentoVM:clsVMBase
    {
        #region atributos

        clsDepartamento deptRecogido;
        DelegateCommand cancelarCommand;//Esto lleva a otra vista
        DelegateCommand guardarCommand;
        #endregion

        #region constructores
        public editarDepartamentoVM()
        {
            
            guardarCommand = new DelegateCommand(guardarCommandExecute /*guardarCommandCanExecute*/);
            cancelarCommand = new DelegateCommand(cancelarCommandExecute, cancelarCommandCanExecute);

        }
        public editarDepartamentoVM(clsDepartamento departamento)
        {
            this.deptRecogido=departamento;
            guardarCommand = new DelegateCommand(guardarCommandExecute /*guardarCommandCanExecute*/);
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
        public clsDepartamento DeptRecogido
        {
            get { return deptRecogido; }
            set
            {
                deptRecogido = value;
                NotifyPropertyChanged("DeptRecogido");
                cancelarCommand.RaiseCanExecuteChanged();
                guardarCommand.RaiseCanExecuteChanged();
            }
        }


        #endregion

        #region comandos
        private bool cancelarCommandCanExecute()
        {
            bool puedeCancelar = false;

            if (deptRecogido != DeptRecogido)
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

        /*
        private bool guardarCommandCanExecute()
        {

            bool puedeGuardar = false;

            if (deptRecogido != DeptRecogido)
            {
                puedeGuardar = true;

            }
            return puedeGuardar;
        }
        */
        private async void guardarCommandExecute()
        {

            //Manda la persona a la bbdd.
            await clsHandlerDepartamentoBL.actualizaDepartamentoBL(deptRecogido);

            //Aquí hay que comprobar si se ha insertado en la api

            //Esto navegará al listado.
            await Shell.Current.Navigation.PushAsync(new listadoDepartamentos()); //va el departamento seleccionado de param

        }

        #endregion


        #region métodos y funciones

        #endregion
    }
}
