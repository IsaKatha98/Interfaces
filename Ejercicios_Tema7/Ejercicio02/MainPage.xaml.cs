namespace Ejercicio02

{
    public partial class MainPage : NavigationPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new PaginaTabbed());
        }
    }
}