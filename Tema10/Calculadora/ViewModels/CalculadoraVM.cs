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
        DelegateCommand clearDisplayCommand; //Comando que borra todo.
        DelegateCommand<string> numCommand; //Comando que lee números.
        DelegateCommand<string> simbolosCommand; //Comando que lee los símbolos.
        DelegateCommand operacionesCommand; //se ejecuta cuando se pulsa =
        DelegateCommand limpiarCommand;//comando que borra la posición anterior.
        string display;
        string numPulsado;
        #endregion

        #region constructores
        public CalculadoraVM()
        {
            display = string.Empty;
            clearDisplayCommand = new DelegateCommand(clearDisplayCommandExecute, clearDisplayCommandCanExecute);
            operacionesCommand = new DelegateCommand(operacionesCommandExecute, operacionesCommandCanExecute);
            limpiarCommand = new DelegateCommand(limpiarCommandExecute, limpiarCommandCanExecute);
            numCommand = new DelegateCommand<string>(numCommandExecute); //siempre va a estar habilitado.
            simbolosCommand = new DelegateCommand<string>(simbolosCommandExecute);//siempre va a estar habilitado
            numPulsado = string.Empty;
       
        }
        #endregion

        #region propiedades
        public string Display
        {
            get { return display; }
          

        }

        public string NumPulsado
        {
            get { return numPulsado; }
            set
            {
                numPulsado = value;
                NotifyPropertyChanged("NumPulsado");
            }
        }

        public DelegateCommand ClearDisplayCommand
        {
            get { return clearDisplayCommand; }
        }

        public DelegateCommand<string> NumCommand
        {
            get { return numCommand; }
        }

        public DelegateCommand<string> SimbolosCommand
        {
            get { return simbolosCommand;}
        }

        public DelegateCommand OperacionesCommand
        {
            get { return operacionesCommand; }
        }

        public DelegateCommand LimpiarCommand
        {
            get { return limpiarCommand; }

        }

        #endregion

        #region comandos

        private bool clearDisplayCommandCanExecute()
        {
            bool puedeBorrar=false;

            if (!string.IsNullOrEmpty(display) )
            {
                puedeBorrar = true;
            }

            return puedeBorrar;

        }

        private void clearDisplayCommandExecute()
        {
            display=string.Empty;
            NotifyPropertyChanged("PropiedadQueSeVe");
            clearDisplayCommand.RaiseCanExecuteChanged();
        }

        private bool limpiarCommandCanExecute()
        {
            bool puedeBorrar = false;


            return puedeBorrar;
        }

        private void limpiarCommandExecute()
        {

        }

        private void numCommandExecute(Object args)
        {
            numPulsado = args.ToString();
            //Necesitamos coger la última posición del atributo
            if (display==string.Empty)
            {
                
                //hacemos un switch case.
                switch (numPulsado)
                {
                    case "0":
                        display = display + "0";
                        break;

                    case "1":
                        display = display + "1";
                        break;
                    case "2":
                        display = display + "2";
                        break;
                    case "3":
                        display = display + "3";
                        break;
                    case "4":
                        display = display + "4";
                        break;
                    case "5":
                        display = display + "5";
                        break;
                    case "6":
                        display = display + "6";
                        break;
                    case "7":
                        display = display + "7";
                        break;
                    case "8":
                        display = display + "8";
                        break;
                    case "9":
                        display = display + "9";
                        break;

                    case ".":
                        display+= ".";
                        break;

                }

               
            
            } else
            {
      
                //hacemos un switch case.
                switch (numPulsado)
                {
                    case "0":
                        display = display + "0";
                        break;

                    case "1":   
                        display = display + "1";
                        break;
                    case "2":
                        display = display + "2";
                        break;
                    case "3":
                        display = display + "3";
                        break;
                    case "4":
                        display = display + "4";
                        break;
                    case "5":
                        display = display + "5";
                        break;
                    case "6":
                        display = display + "6";
                        break;
                    case "7":
                        display = display + "7";
                        break;
                    case "8":
                        display = display + "8";
                        break;
                    case "9":
                        display = display + "9";
                        break;

                    case ".":
                        display+= ".";
                        break;

                }

            }

            NotifyPropertyChanged("Display");
            clearDisplayCommand.RaiseCanExecuteChanged();


        }

        private void  simbolosCommandExecute(Object args)
        {
            numPulsado = args.ToString();

            switch (numPulsado)
            {
                case "+":
                    display += "+";
                    break;
                case "-":
                    display += "-";
                    break;
                case "*":
                    display += "*";
                    break;
                case "/":
                    display += "/";
                    break;

               

            }

            NotifyPropertyChanged("Display");

        }

        private bool operacionesCommandCanExecute()
        {
            bool puedeOperar = true;


            return puedeOperar;
        }

        private void operacionesCommandExecute()
        {

        }

        #endregion

        #region métodos y funciones
        


        #endregion

    }
}
