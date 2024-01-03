using Ejercicio01.ViewModels.Utils;
using Ejercicio02.ViewModels.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using BL.ListadosBL;

namespace Ejercicio02.Viewmodels
{
    public class editarPersonaVM:clsVMBase
    {
        #region atributos
        clsPersona persona;
        DelegateCommand cancelarCommand;
        DelegateCommand guardarCommand;
        #endregion

        #region constructores
        public editarPersonaVM()
        {
            cargaPersona();
        }
      

        private async void cargaPersona(int id)
        {
            persona= await clsListadoPersonasBL.readDetailsPersonaBL(id);
            NotifyPropertyChanged("Persona");
        }
        #endregion



    }
}
