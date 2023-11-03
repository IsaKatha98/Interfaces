namespace Entidades
{
    public class clsPersona
    {
        #region atributos

        string nombre;
        string apellidos;

        #endregion

        #region constructor

        public clsPersona(String nombre, string apellidos)
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

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        #endregion
    
    }
}