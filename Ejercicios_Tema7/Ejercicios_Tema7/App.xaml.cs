using Ejercicios_Tema7.Views;

namespace Ejercicios_Tema7
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PageTabbed();
        }
    }
}