using Ejercicio01.ViewModels.Utils;
using Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Viewmodels
{
    public class listadoPersonasVM: clsVMBase
    {
        #region atributos
        ObservableCollection<clsPersona> listaPersonas;
        #endregion
    }
}
