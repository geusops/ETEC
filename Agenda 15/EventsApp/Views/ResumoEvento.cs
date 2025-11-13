namespace EventsApp.Views;

public partial class ResumoEvento : ContentPage
{
    public ResumoEvento()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new InfoEvent());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Ok");
        }
        
    }
}
