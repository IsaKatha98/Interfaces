namespace Calendarios
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void elegirFecha(object sender, DateChangedEventArgs e)
        {
            // Cuando se selecciona una fecha de entrada, habilitar el DatePicker de salida
            fechaSalida.MinimumDate = fechaEntrada.Date;
            fechaSalida.IsEnabled = true;
        }

    }
}