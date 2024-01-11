using Ejercicio01.ViewModels.Utils;
using Ejercicio02.ViewModels.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using BL.ListadosBL;
using Ejercicio02.Models;
using BL.HandlerBL;
using Ejercicio02.Views;

namespace Ejercicio02.Viewmodels
{
    public class editarPersonaVM:clsVMBase
    {
        #region atributos
        clsPersonaDepartamento persona;
        DelegateCommand cancelarCommand;
        DelegateCommand guardarCommand;
        #endregion

        #region constructores
        public editarPersonaVM()
        {

            guardarCommand = new DelegateCommand(guardarCommandExecute /*guardarCommandCanExecute*/);
            cancelarCommand = new DelegateCommand(cancelarCommandExecute, cancelarCommandCanExecute);

        }
        public editarPersonaVM(clsPersonaDepartamento persona)
        {
            this.persona = persona;
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
        public clsPersonaDepartamento Persona
        {
            get { return persona; }
            set
            {
                persona = value;
                NotifyPropertyChanged("Persona");
                cancelarCommand.RaiseCanExecuteChanged();
                guardarCommand.RaiseCanExecuteChanged();
            }
        }


        #endregion

        #region comandos
        private bool cancelarCommandCanExecute()
        {
            bool puedeCancelar = false;

            if (persona != Persona)
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

            if (persona != Persona)
            {
                puedeGuardar = true;

            }
            return puedeGuardar;
        }
        */
        private async void guardarCommandExecute()
        {
            clsPersona p= new clsPersona();

            p.Nombre= persona.Nombre;
            p.Apellidos= persona.Apellidos;
            p.Id= persona.Id;
            p.Direccion= persona.Direccion;
            p.FechaNac= persona.FechaNac;
            p.FotoURL= persona.FotoURL;
            p.IdDepartamento= persona.IdDepartamento;

            //Manda la persona a la bbdd.
            await clsHandlerPersonaBL.actualizaPersonaBL(p);

            //Esto navegará al listado.
            await Shell.Current.Navigation.PushAsync(new listadoPersonas()); //va el departamento seleccionado de param

        }
        
        #endregion


        #region métodos y funciones

        #endregion




    }
}
