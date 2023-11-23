using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01.Models.Entities
{
    public class clsPersona
    {
        #region atributos
        private int idPersona;
        private string nombre;
        private string apellidos;
        

        #endregion

        #region constructores
        public clsPersona()
        {
            idPersona = 0;
            nombre = "";
            apellidos = "";
           
        }

        public clsPersona(int idPersona, string nombre, string apellidos)
        {
            this.idPersona = idPersona;
            this.nombre = nombre;
            this.apellidos = apellidos;
           

        }
        #endregion

        #region propiedades

        public int IdPersona
        {
            get { return idPersona; }
            set { idPersona = value; }

        }
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

        public string NombreCompleto
        {
            get { return Nombre + " " + Apellidos; }

        }
        #endregion
    }
}
