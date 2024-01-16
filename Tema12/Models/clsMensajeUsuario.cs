using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class clsMensajeUsuario
    {
        string nombreUsuario;
        string mensajeUsuario;
        public clsMensajeUsuario() { }

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public string MensajeUsuario
        {
            get { return mensajeUsuario; }
            set { mensajeUsuario = value; }
        }
    }
}
