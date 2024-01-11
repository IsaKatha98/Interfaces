using Ejercicio02.Viewmodels;
using Entities;

namespace Ejercicio02.Views;

public partial class EditarDepartamento : ContentPage
{
    public EditarDepartamento(clsDepartamento departamento)
	{
		
		InitializeComponent();

		editarDepartamentoVM vm = new editarDepartamentoVM(departamento);
		BindingContext= vm;
		


	}

}