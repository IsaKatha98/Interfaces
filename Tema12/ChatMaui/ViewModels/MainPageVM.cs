using ChatMaui.ViewModels.Utils;
using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMaui.ViewModels
{
    //mi vista necesita un botón para enviar, necesita un sender y un user que serán
    //propiedades de clsMensajeUsuario, necesita una lista que va mostrando los mensajes.
    public class MainPageVM: clsVMBase
    {
        #region atributos
        private clsMensajeUsuario oMensajeUsuario;
        private string nombreUsuario;
        private string mensajeUsuario;
        private DelegateCommand enviarCommand;
        ObservableCollection<clsMensajeUsuario> listaMensajes;
        #endregion

        #region constructores

        public MainPageVM()
        {
            //TODO: aquí hace falta la conexión también y todo el rollo.
            listaMensajes = new ObservableCollection<clsMensajeUsuario>();
            enviarCommand = new DelegateCommand(enviarExecute, enviarCanExecute);
        }

        #endregion

        #region propiedades

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value;

                NotifyPropertyChanged("NombreUsuario");
                enviarCommand.RaiseCanExecuteChanged();
            }

        }

        public string MensajeUsuario
        {
            get { return mensajeUsuario; }
            set
            {
                mensajeUsuario = value;

                NotifyPropertyChanged("mensajeUsuario");
                enviarCommand.RaiseCanExecuteChanged();
            }

        }

        public DelegateCommand EnviarCommand { get { return enviarCommand; } }


        #endregion

        #region comandos

        private bool enviarCanExecute ()
        {
            bool seEnvia= false;

            if (!string.IsNullOrEmpty(nombreUsuario)&&!string.IsNullOrEmpty(mensajeUsuario))
            {
                seEnvia = true;
            }

            return seEnvia;
        }

        private void enviarExecute()
        {
            //aquí va el send y tal.
        }

        #endregion

    }
}
