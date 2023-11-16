using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Ejercicio04.ViewModel
{
    //La clase implementa la interfaz de notificación de cambio
    public class clsTroleoMaximo:INotifyPropertyChanged
    {
            #region Atributos
            private string nombre;
            private string apellidos;

            //Me creo un objeto persona, hay que instanciarlo
            //sino me da un error de que persona es null.
            private clsPersona persona = new clsPersona();
            #endregion

            #region constructores
            public clsTroleoMaximo()
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

                   //Cuando seteamos el nombre comprobamos si contiene la n.
                   //Si es así, borramos apellidos y hacemos que salte una notificación.

                    if (nombre.Contains("n")||nombre.Contains("N")) {
                
                        Apellidos = "";

                  
                        NotifyPropertyChanged();

                }

                NotifyPropertyChanged();


            }
            }

            public string Apellidos
            {
                get { return apellidos; }
                set
            {
                    apellidos = value;

                // Cuando seteamos el apellido comprobamos si contiene la n.
                //Si es así, borramos apellidos y hacemos que salte una notificación.

                if (apellidos.Contains("n")||apellidos.Contains("N")){
                    Nombre = "";

                    NotifyPropertyChanged();
                }
                    NotifyPropertyChanged();

                }

            }
            #endregion


            public event PropertyChangedEventHandler PropertyChanged;

            private void NotifyPropertyChanged([CallerMemberName] System.String propertyName = "")

            {

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            }

         
        }
}
