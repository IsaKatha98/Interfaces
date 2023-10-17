using Ejercicios.Views;

namespace Ejercicios
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PaginaTabbed();
        }
    }
}