using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio03.ViewModel
{
    //La clase persona implementa la interfaz de notificación de cambio
    public class clsPersonaNotify: INotifyPropertyChanged
    {

        #region Atributos
        private string nombre;
        private string apellidos;

        //Me creo un objeto persona
        clsPersona persona = new clsPersona();
        #endregion

        #region constructores
        public clsPersonaNotify()
        {
            this.nombre = persona.Nombre;
            this.apellidos = persona.Apellidos;

        }
        #endregion

        #region propiedades
        public string Nombre
        {
            get { return nombre; }
            set

            {

                nombre = value;

                // Call OnPropertyChanged whenever the property is updated
                NotifyPropertyChanged();

            }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set
            {
                apellidos = value;

                // Call OnPropertyChanged whenever the property is updated
                NotifyPropertyChanged();

            }

        }
        #endregion

        #region metodos

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")

        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
        #endregion

    }
}
