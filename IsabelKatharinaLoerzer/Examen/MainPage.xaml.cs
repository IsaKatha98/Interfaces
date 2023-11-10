

namespace Examen
{

    //Me falta por comprobar que se pintan bien los errores y que se suman bien los errores y las diferencias encontradas.

    public partial class MainPage : ContentPage
    {
        //variable que va contando el número de clicks
        int numErrores = 0;
        int numDiferencias = 0;
        

        public MainPage()
        {
            InitializeComponent();
           
           

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void TapGestureRecognizer_Image1(object sender, EventArgs e)
    

        {
            diferencia1(sender, e);
            //diferencia2(sender, e);
            //diferencia3(sender, e);

            if (numErrores == 3)
            {

                //Hacemos el display alert.

                bool answer = await DisplayAlert("Ha perdido", "¿Quiere volver a intentarlo?", "Sí", "No");

                if (answer)
                {
                    numErrores = 0;
                    mensaje.Text = "Número de errores que lleva: " + numErrores.ToString();
                    diferencia.Text = "Diferencias encontradas: " + numDiferencias.ToString();
                }
                else
                {
                    Application.Current.Quit();
                }

            }
            else
            {
                numErrores++;
                mensaje.Text = "Número de errores que lleva: " + numErrores.ToString();
                diferencia.Text = "Diferencias encontradas: " + numDiferencias.ToString();
            }

        }

        private async void TapGestureRecognizer_Image2(object sender, EventArgs e)
        {
            if (numErrores == 3)
            {

                //Hacemos el display alert.

                bool answer = await DisplayAlert("Ha perdido", "¿Quiere volver a intentarlo?", "Sí", "No");

                if (answer)
                {
                    numErrores = 0;
                    mensaje.Text = "Número de errores que lleva: " + numErrores.ToString();
                    diferencia.Text = "Diferencias encontradas: " + numDiferencias.ToString();
                }
                else
                {
                    Application.Current.Quit();
                }

            }
            else
            {
                numErrores++;
                mensaje.Text = "Número de errores que lleva: " + numErrores.ToString();
                diferencia.Text = "Diferencias encontradas: " + numDiferencias.ToString();
            }
        }


        private void diferencia1(object sender, EventArgs e)
        {
            numDiferencias++;
            numErrores--;
            mensaje.Text = "Número de errores que lleva: " + numErrores.ToString();
            diferencia.Text = "Diferencias encontradas: " + numDiferencias.ToString();

            //Cambiamos la opacidad del borde.
            borde1.Opacity = 1;
            borde4.Opacity = 1;
           
        }
        private void diferencia2(object sender, EventArgs e)
        {
            numDiferencias++;
            numErrores--;
            mensaje.Text = "Número de errores que lleva: " + numErrores.ToString();
            diferencia.Text = "Diferencias encontradas: " + numDiferencias.ToString();

            //Cambiamos la opacidad del borde.
            borde2.Opacity = 1;
            borde5.Opacity = 1;

        }
        private void diferencia3(object sender, EventArgs e)
        {
            numDiferencias++;
            numErrores--;
            mensaje.Text = "Número de errores que lleva: " + numErrores.ToString();
            diferencia.Text = "Diferencias encontradas: " + numDiferencias.ToString();

            //Cambiamos la opacidad del borde.
            borde3.Opacity = 1;
            borde6.Opacity = 1;

        }

        /// <summary>
        /// Método que hace controla el display alert del final del juego.
        /// </summary>
        /// <param name="titulo"></param>
        /// <param name="mensaje"></param>
        private async void mensajeFinal (string titulo, string mensaje)
        {
            bool answer = await DisplayAlert(titulo, mensaje, "Sí", "No");
            
            if (answer)
            {
                numErrores = 0;

                //TODO: terminar 
            }
        
        }



    }


}