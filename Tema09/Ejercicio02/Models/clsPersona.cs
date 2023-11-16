using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Ejercicio02.Models
{
    //La clase persona implementa la interfaz de notificación de cambio
    public class clsPersona : INotifyPropertyChanged
    {

        #region atributos
        private string nombre;
        private string apellidos;
     
        #endregion

        #region constructores
        public clsPersona()
        {

            nombre = "Isabel Katharina";
            apellidos = "Loerzer";
         
        }

        public clsPersona(string nombre, string apellidos)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
           
        }
        #endregion

        #region propiedades
        public string Nombre
        {
            get { return nombre; }
            set { 
                
                nombre = value;

                // Call OnPropertyChanged whenever the property is updated
                NotifyPropertyChanged();

            }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { 
                apellidos = value;

                // Call OnPropertyChanged whenever the property is updated
                NotifyPropertyChanged();

            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    #endregion
}
}
