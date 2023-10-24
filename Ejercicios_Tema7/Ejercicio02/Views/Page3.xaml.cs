namespace Ejercicio02.Views;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}
    private async void OnCounterClicked(object sender, EventArgs e)
    {

        await Navigation.PopToRootAsync();
    }
}