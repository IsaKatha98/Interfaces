using PlacasSolares.Entities;
using PlacasSolares.DAL;

namespace PlacasSolares.Views;

public partial class pagUbicacion : ContentPage
{
	public pagUbicacion()
	{
		InitializeComponent();

		Fecha.Text = DateOnly.FromDateTime(DateTime.Today).ToString();

		clsCita cita = new clsCita(16, "Carmen Martin","Calle San Cristobal, 8", 653873241,"Instalación de placas de tipo A", "09:30" );

		tipo.Text = cita.Tipo;

		hora.Text = cita.Hora;
		nombre.Text = cita.Nombre;
		tlf.Text=cita.Tlf.ToString();
		direccion.Text=cita.Direccion;



	}

    private async void btnDetalles_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new pagDetalles());
    }
}