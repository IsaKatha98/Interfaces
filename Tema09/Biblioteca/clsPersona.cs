using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class clsPersona
    {
        #region atributos
        private string nombre;
        private string apellidos;

        #endregion

        #region constructores

        public clsPersona() { 
        
            nombre = string.Empty;
            apellidos = string.Empty;
        
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
            set
            {

                nombre = value;

            }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set
            {
                apellidos = value;

            }

        }

        #endregion

    }
}
