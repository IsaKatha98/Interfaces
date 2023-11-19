using Ejercicio05.Views;

namespace Ejercicio05
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new listadoPersonas());
        }
    }
}