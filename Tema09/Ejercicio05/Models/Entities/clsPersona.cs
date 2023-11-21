using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05.Models.Entities
{
    public class clsPersona
    {
        #region atributos
        private string nombre;
        private string apellidos;
        private DateOnly fechaNac;
        private string foto;
        private string direccion;
        private string tlf;

        #endregion

        #region constructores

       
        public clsPersona()
        {

            nombre = string.Empty;
            apellidos = string.Empty;
            fechaNac = new DateOnly();
            foto = string.Empty;
            direccion = string.Empty;
            tlf = "0";

        }

        public clsPersona( string nombre, string apellidos, string foto)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Foto = foto;
          
        }

        public clsPersona(string nombre, string apellidos, DateOnly fechaNac, string foto, string direccion, string tlf)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNac = fechaNac;
            this.foto = foto;
            this.direccion = direccion;
            this.tlf = tlf;

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

        public DateOnly FechaNac
        { 
            get { return fechaNac; }
            set { fechaNac = value; }
        }

        public string Foto
        {
            get { return foto; }
            set { foto = value; }

        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }

        }

        public string Tlf
        { 
            get { return tlf; } 
            set { tlf = value; } 
        }

        #endregion

    }
}
