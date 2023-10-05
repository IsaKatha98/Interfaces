using Biblioteca;

namespace HolaMundo_Tema05
{
    public partial class MainPage : ContentPage
    {
 

        public MainPage()
        {
            InitializeComponent();
        }

        public async void Validate (object sender, EventArgs e){

            clsPersona per = new clsPersona();
            
            per.Apellidos = await DisplayPromptAsync("Ingrese sus apellidos", "");

            per.Nombre= nombre.Text;

            await DisplayAlert("Saludo","Hola "+per.Nombre+" "+per.Apellidos,"Holiwi");
        }
    }
}