namespace PlacasSolares.Views;

public partial class pagDetalles : ContentPage
{
	public pagDetalles()
	{
		InitializeComponent();

        Fecha.Text = DateOnly.FromDateTime(DateTime.Today).ToString();
    }

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
     
        if (check.IsChecked == true)
        {
            lblCheckbox.Text = "Es apta";
            lblCheckbox.TextColor = Colors.Green;
            check.Color = Colors.Green;
        
        } else
        {
            lblCheckbox.Text = "No es apta";
            lblCheckbox.TextColor = Colors.Red;
            check.Color = Colors.Red;
        } 
           
        
      
    }
}