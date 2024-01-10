using Ejercicio02.Models;
using Ejercicio02.Viewmodels;
using Entities;

namespace Ejercicio02.Views;

public partial class EditarPersona : ContentPage
{
	public EditarPersona( clsPersonaDepartamento persona)
	{
		InitializeComponent();
       

        editarPersonaVM vm = new editarPersonaVM(persona);
        BindingContext = vm;

    }
}