﻿namespace Botones
{
    public partial class MainPage : ContentPage
    {

        Boolean btnYaCreado = false;

        public MainPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Descripción: método que comprueba si el botón 3 existe y en caso contrario, lo crea.
        /// Precondiciones: que el sender 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void evento_ClickedBtn2(object sender, EventArgs e)
        {
            //creamos un botón nuevo.

            if (btnYaCreado!=true)
            {

                Button btn3 = new Button 
                {

                    Text = "Botón 3",
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    BackgroundColor = Colors.LightBlue,
                    HeightRequest = 70,
                    MinimumWidthRequest = 200,
                    FontFamily = "Verdana",
                    FontSize = 16,
                    FontAttributes = FontAttributes.Bold,
                    BorderColor = Colors.Yellow,
                    Margin = 30

                };

                //añadimos un botón y añadimos el evento.

                vslButtons.Add(btn3);
                btn3.Clicked += evento_ClickedBtn3;

                //también se puede hacer btn3.Clicked += new System.EventHandler(evento_ClickedBtn3);
                btnYaCreado = true;

            }
           

    
        }

        private void evento_ClickedBtn3 (object sender, EventArgs e)
        {
            vslButtons.Remove(btn1);
           // btn2.WidthRequest = 500;
            btn2.Text = "Crear controles en tiempo de ejecución mola";


        }


    }
}