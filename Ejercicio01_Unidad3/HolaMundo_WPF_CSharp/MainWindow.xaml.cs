using LibreriaComun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HolaMundo_WPF_CSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Declaramos el objeto de tipo clsPersona
        /// </summary>
        clsPersona per1 = new clsPersona();

        /// <summary>
        /// Evento asociado a
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
          

        }

        private void btnSaludar_Click(object sender, RoutedEventArgs e)
        {
            ///Asignamos el valor de lo que se mete en el textbox.
            per1.Nombre = txtNombre1.Text;

            ///hacemos que muestre el mensaje.
            MessageBox.Show("Hola, " + per1.NombreCompleto, "Saludo");

        }
    }
}
