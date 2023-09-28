﻿namespace LibreriaComun
{
    internal class clsPersona
    {


        #region atributos
        private String nombre;
        private String apellidos;
        #endregion


        #region constructores
        public clsPersona()
        {
            nombre = "";
            apellidos = "";
        }

        public clsPersona(string nombre, string apellidos)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
        }
        #endregion


        #region propiedades
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }

        }
        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public String NombreCompleto
        {
            get { return nombre + " " + apellidos; }
        }


        public String Direccion { get; set; }

        public String FuncionNombreCompleto()
        {
            return $"Su nombre completo es: {nombre} {apellidos}";
        }
        #endregion
    }
}
