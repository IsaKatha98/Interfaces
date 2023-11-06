namespace Ejercicio06.Views

{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void clickOnEditar(object sender, EventArgs e)
        {

           
        }

        private async void clickOnSave(object sender, EventArgs e)
        {

            bool answer = await DisplayAlert("Guardar", "¿Seguro que quiere guardar esos datos?", "Sí", "No");
         
        }
        private async void clickOnDelete(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Eliminar", "¿Seguro que quiere eliminar esos datos?", "Sí", "No");

            if (answer)
            {
                entryNombre.Text= "";
                entryApellidos.Text = "";
                entryFechaNac.Text = "";
            }

        }

    }
}