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
        private int idPersona;

        #endregion

        #region constructores
        public clsPersona()
        {

            nombre = "Isabel Katharina";
            apellidos = "Loerzer";
            idPersona = 1;

        }

        public clsPersona(string nombre, string apellidos, int idPersona)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.idPersona = idPersona;
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

        public int IdPersona
        {
            get { return idPersona; }
            set { idPersona = value; }

        }

        public string NombreCompleto
        {
            get { return Nombre + " " + Apellidos; }

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    #endregion
}
}
