namespace EjemploShell
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            MainPage=new AppShell();
        }
    }
}