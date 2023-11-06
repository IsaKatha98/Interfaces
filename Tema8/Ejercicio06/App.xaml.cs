namespace Ejercicio06;
using Ejercicio06.Views;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new MainPage());
    }
}