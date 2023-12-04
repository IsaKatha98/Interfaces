using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio01.ViewModels.Utils;




namespace Calculadora.ViewModels
{
    public class CalculadoraVM:clsVMBase
    {
        #region atributos
        DelegateCommand clearCommand; //Comando que borra todo.
        DelegateCommand digitCommand; //Comando que lee números.
        DelegateCommand operacionesCommand; //Comando que realiza las operaciones
        string propiedadQueSeVe;
        #endregion

        #region constructores
        public CalculadoraVM()
        {
            propiedadQueSeVe = string.Empty;
            clearCommand = new DelegateCommand(clearCommandExecute, clearCommandCanExecute);
            digitCommand = new DelegateCommand(digitCommandExecute); //siempre va a estar habilitado.
            operacionesCommand = new DelegateCommand(operacionesCommandExecute);//siempre va a estar habilitado

            
        }
        #endregion

        #region propiedades
        public string PropiedadQueSeVe
        {
            get { return propiedadQueSeVe; }
            set { propiedadQueSeVe = value; }

        }

        public DelegateCommand ClearCommand
        {
            get { return clearCommand; }
        }

        public DelegateCommand DigitCommand
        {
            get { return digitCommand; }
        }

        public DelegateCommand OperacionesCommand
        {
            get { return operacionesCommand;}
        }

        #endregion

        #region comandos

        private void digitCommand()
        {

        }

        #endregion

    }
}
