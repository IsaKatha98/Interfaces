﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio05.Models.DAL;
using Ejercicio05.Models.Entities;
using System.Collections.ObjectModel;
using Ejercicio05.Views;
using System.Windows.Input;

//Esta clase presenta una lista de personas, que es un ObservableCollection, 
//implementa la clsPersona.
namespace Ejercicio05.ViewModel
{
    public class listadoPersonasVM
    {
        #region atributos
        //Atributo listadoPersonas que es un observableCollection de tipo clsPErsona (DAL)
        private ObservableCollection<clsPersona> listadoPersonas;
        //Atributo persona de tipo clsPersonas (Entities)
        private clsPersona persona= new clsPersona();

        
        #endregion

        #region constructores
        public listadoPersonasVM()
        {
            //Nos traemos la lista de personas de la capa DAL.
            listadoPersonas = clsListados.listados();

        }
        #endregion
        #region propiedades
        public ObservableCollection<clsPersona> ListadoPersonasVM
        {
            //Devolvemos el listadoPersonas.
            get { return listadoPersonas; }

        }

        public clsPersona Persona
        {
            get { return persona; }
        }

       
        #endregion

        

    }
    
}
