using Org.Apache.Http.Conn;

namespace Botones
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void evento_Clicked(object sender, EventArgs e)
        {
            Button btn3 = new Button {

                Text = "Botón 3",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                BackgroundColor = Colors.LightBlue,


            }

    
        }


    }
}