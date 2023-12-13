using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.ListadosBL;
using Entities;

namespace Ejercicio01.Viewmodels
{
    public class MainPageVM
    {
        #region atributos
        private ObservableCollection<clsPersona> listadoPersonas;

        private List<clsPersona> listaPersonasBL;
        #endregion

        #region constructores
        public MainPageVM()
        {
            cargarPersonas();
                
        }
        #endregion

        #region propiedades
        public ObservableCollection<clsPersona> ListadosPersonas { get { return listadoPersonas; } }

        #endregion

        #region metodos
        private async Task cargarPersonas()
        {
            //llamamos a la capa BL
            listaPersonasBL= await clsListadoPersonasBL.ListadoCompletoPersonasBL();
            listadoPersonas = new ObservableCollection<clsPersona>(listaPersonasBL);

        }
        #endregion
    }
}
