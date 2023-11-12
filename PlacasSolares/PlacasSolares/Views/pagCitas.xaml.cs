namespace PlacasSolares.Views;

using PlacasSolares.DAL;
using PlacasSolares.Entities;
using System.Collections.ObjectModel;

public partial class pagCitas : ContentPage
{
	public pagCitas()
	{
		InitializeComponent();
        Fecha.Text = DateTime.Today.ToString();
        CitasListView.ItemsSource = Citas;
       

    }


    public ObservableCollection<clsCita> Citas
    {
        get { return clsListadoCitas.getListadoCitas(); }
    }

    private async void CitasListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {

    }
}