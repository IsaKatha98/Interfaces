using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Models
{
    public class clsPersonaDepartamento:clsPersona
    {
        #region atributos
        private string nombreDepartamento;
        #endregion

        #region constructores
        public clsPersonaDepartamento() 
        { }
        public clsPersonaDepartamento(clsPersona p)
        {
            this.Nombre=p.Nombre;
            this.Apellidos=p.Apellidos;
            this.Direccion=p.Direccion;
            this.FechaNac=p.FechaNac;
            this.FotoURL=p.FotoURL;
            this.Id=p.Id;
            this.IdDepartamento=p.IdDepartamento;
            this.Tlf=p.Tlf;
            nombreDepartamento = "";
        }
        #endregion

        #region propiedades
        public string NombreDepartamento 
        { 
            get { return nombreDepartamento; } 
            set { nombreDepartamento = value; }
        }
        #endregion

        
    }
}
