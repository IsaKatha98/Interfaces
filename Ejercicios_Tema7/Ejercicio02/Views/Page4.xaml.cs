
using Biblioteca;

namespace Ejercicio02.Views;

public partial class Page4 : ContentPage
{
	public Page4(clsPersona persona)
	{
		InitializeComponent();

		Nombre.Text=persona.Nombre;
		Apellidos.Text=persona.Apellidos;

	}
}