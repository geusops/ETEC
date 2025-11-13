using EventsApp.Models;

namespace EventsApp.Views;

public partial class InfoEvent : ContentPage
{
    public InfoEvent()
    {
        InitializeComponent();

        dtpck_inicio.MinimumDate = DateTime.Now;
        dtpck_inicio.MaximumDate = DateTime.Now.AddMonths(3);

    }



    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            CalculoEvento re = new CalculoEvento
            {
                NomeEvento = txt_nome_evento.Text,
                DataInicio = dtpck_inicio.Date,
                DataTermino = dtpck_termino.Date,
                NumeroParticipantes = Convert.ToInt32(txt_numero_participantes.Text),
                LocalEvento = txt_local_Evento.Text,
                CustoPorParticipante = Convert.ToDouble(txt_custo_participante.Text),

            };

            await Navigation.PushAsync(new ResumoEvento()
            {
                BindingContext = re
            });

        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "Ok");
        }
    }

    private void dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada = elemento.Date;
        
        dtpck_termino.MinimumDate = data_selecionada.AddDays(1);
        dtpck_termino.MaximumDate = data_selecionada.AddMonths(1);
    }

}
