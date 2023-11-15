using Ejercicio02.Models;

namespace Ejercicio02.Views
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            // Crear una instancia del modelo Persona y establecerla como BindingContext
            clsPersona persona = new clsPersona();
            this.BindingContext = persona;
        }

    }
}