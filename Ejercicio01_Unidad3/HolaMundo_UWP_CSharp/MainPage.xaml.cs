using Biblioteca_UWP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace HolaMundo_UWP_CSharp
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Declaramos el objeto de tipo clsPersona
        /// </summary>
        clasePersonaUWP per1 = new clasePersonaUWP();


        private void btnSaludar_Click(object sender, RoutedEventArgs e)
        {

            ///Asignamos el valor de lo que se mete en el textbox.
            per1.Nombre = txtNombre2.Text;

            ///hacemos que muestre el mensaje.
            ContentDialog.  ("Hola, " + per1.NombreCompleto, "Saludo");

        }
    }
}
