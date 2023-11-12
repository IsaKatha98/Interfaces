namespace PlacasSolares.Views
{
    public partial class Login : ContentPage
    {
    

        public Login()
        {
            InitializeComponent();
        }

        private async void entraUsuario (object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pagCitas());
        }

      
    }
}