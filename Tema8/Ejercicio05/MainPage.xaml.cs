using Ejercicio05.Models;
using Entidades;
using System.Collections.ObjectModel;

namespace Ejercicio05
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            ObservableCollection<clsPersona> listadoPersonas = new ObservableCollection<clsPersona>(clsListadoPersonasDAL.listadoPersonas());

            PersonasListView.ItemsSource = listadoPersonas;

            BindingContext = this;




        }     
    }
}