using BL.HandlerBL;
using BL.ListadosBL;
using Ejercicio01.ViewModels.Utils;
using Ejercicio02.Models;
using Ejercicio02.ViewModels.Utils;
using Ejercicio02.Views;
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
        ObservableCollection<clsPersonaDepartamento> listaPersonasNombreDept= new ObservableCollection<clsPersonaDepartamento>();
        clsPersonaDepartamento personaSeleccionada;
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
            //Nos traemos la lista.
            List<clsPersona> listaPersonas = new List<clsPersona>(await clsListadoPersonasBL.listadoCompletoPersonasBL());

            ObservableCollection<clsPersonaDepartamento> listaPersonasDepartamento= new ObservableCollection<clsPersonaDepartamento>();

            foreach (clsPersona p in listaPersonas)
            {
                clsPersonaDepartamento per = new clsPersonaDepartamento(p);

                //Obviamos a las personas nulas.
                if (per != null)
                {
                    //Rellenamos el listado de personas con departamento pero que no saben el nombre del departamento.
                    listaPersonasDepartamento.Add(per);
                }             
            }
            
            //Recorremos la segunda lista
            foreach (clsPersonaDepartamento persona in listaPersonasDepartamento)
            {
                //Ahora, buscamos el departamento de cada persona.
                clsDepartamento departamento = await clsListadoDepartamentoBL.readDetailsDepartamentoBL(persona.IdDepartamento);

                //Asignamos el nombre
                if (departamento==null)
                {
                    persona.NombreDepartamento = "No tiene departamento asignado.";

                } else
                {
                    persona.NombreDepartamento = departamento.Nombre;
                }
               

                //añadimos la persona a la lista.
                listaPersonasNombreDept.Add(persona);
            }

            //Notificamos que ha habido cambios en la propiedad ListaPersonas, para que la cargue la vista.
            NotifyPropertyChanged("ListaPersonasNombreDept");
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

        public ObservableCollection<clsPersonaDepartamento> ListaPersonasNombreDept

        {
            get { return listaPersonasNombreDept; }

        }


        public clsPersonaDepartamento PersonaSeleccionada
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

        private async void eliminarCommandExecute()
        {

            await clsHandlerPersonaBL.borrarPersonaDAL(personaSeleccionada.Id);


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
            ObservableCollection<clsPersonaDepartamento> listaPersonasEncontradas = new ObservableCollection<clsPersonaDepartamento> (listaPersonasNombreDept.Where(persona=>persona.Nombre.Contains(textoBusqueda)).ToList());
            
            //Igualamos las listas.
            listaPersonasNombreDept = listaPersonasEncontradas;

            //notificamos el cambio.
            NotifyPropertyChanged("ListaPersonasNombreDept");

            
           //TODO: ahora hay que mostrar esa lista de Personas Encontradas
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

        private async void editarCommandExecute()
        {
            //Aquí nos lleva a otra vista
           await Shell.Current.Navigation.PushAsync(new EditarPersona());


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

        private async void crearCommandExecute()
        {
            //Aquí nos lleva a otra vista
            await Shell.Current.Navigation.PushAsync(new insertarPersona());

        }

        #endregion

        #region métodos y funciones

        //on appearing. evento de código behind. 
        //El evento está en el vm.

        #endregion
    }
}
