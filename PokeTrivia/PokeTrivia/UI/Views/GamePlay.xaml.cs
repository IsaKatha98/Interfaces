using Entities;
using PokeTrivia.UI.VM;

namespace PokeTrivia.UI.Views;

public partial class GamePlay : ContentPage
{
	public GamePlay(GamePlayVM vm)
	{
		InitializeComponent();

		BindingContext= vm;

	}
}