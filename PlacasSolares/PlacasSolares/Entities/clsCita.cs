using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacasSolares.Entities
{
    public class clsCita
    {
        #region atributos
        int id;
        string nombre;
        string direccion;
        long tlf;
        string tipo;
        string hora;

        #endregion

        #region constructores
        public clsCita()
        {
            this.id = 0;
            this.nombre = "";
            this.direccion = "";
            this.tlf = 0;
            this.tipo = "";
            this.hora = "";
        }

        public clsCita(int id, string nombre, string direccion, long tlf, string tipo, string hora)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion=direccion;
            this.tlf = tlf;
            this.tipo = tipo;
            this.hora = hora;
        }

        #endregion

        #region propiedades
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }

        }
        public string Nombre { get {  return this.nombre; } set {  this.nombre = value; } }

        public string Direccion { get {  return this.direccion; } set { this.direccion = value; } }

        public long Tlf { get { return this.tlf; } set { this.tlf = value; } }

        public string Tipo {  get { return this.tipo; } set { this.tipo = value; } }

        public string Hora { get { return this.hora; } set { this.hora = value; } }
        #endregion
    }
}
