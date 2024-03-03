using PokeTrivia.UI.VM;

namespace PokeTrivia.UI.Views;

public partial class Waiting : ContentPage
{
	public Waiting(WaitingVM vm)
	{
		InitializeComponent();
        
		BindingContext = vm;
    }
}