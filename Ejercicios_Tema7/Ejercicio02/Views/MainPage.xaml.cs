using Biblioteca;
namespace Ejercicio02.Views

{
    public partial class MainPage : ContentPage
    {
        clsPersona persona = new clsPersona();
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnTabbedClick(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new PaginaTabbed());
        }
        private async void btnPage4Click(object sender, EventArgs e)
        {
         
            persona.Nombre = txtNombre.Text;
            persona.Apellidos = txtApellidos.Text;

            await Navigation.PushAsync(new Page4(persona)
           );
        }
        private async void btnPage5Click(object sender, EventArgs e)
        {
            

            persona.Nombre = txtNombre.Text;
            persona.Apellidos = txtApellidos.Text;

            await Navigation.PushAsync(new Page4(persona)
            );
        }
    }
}