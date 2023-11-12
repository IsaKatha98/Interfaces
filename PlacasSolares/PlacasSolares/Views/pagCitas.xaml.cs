namespace PlacasSolares.Views;

using PlacasSolares.DAL;
using PlacasSolares.Entities;
using System.Collections.ObjectModel;

public partial class pagCitas : ContentPage
{
	public pagCitas()
	{
		InitializeComponent();
        Fecha.Text = DateOnly.FromDateTime(DateTime.Today).ToString();
        CitasListView.ItemsSource = Citas;
       

    }


    public ObservableCollection<clsCita> Citas
    {
        get { return clsListadoCitas.getListadoCitas(); }
    }

    /// <summary>
    /// Método que lleva a la página de ubicación.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void CitasListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        await Navigation.PushAsync(new pagUbicacion());
    }
}