using MauiAppEvento.Models;
using Microsoft.Maui.ApplicationModel.DataTransfer;

namespace MauiAppEvento.View;

public partial class Evento : ContentPage
{
    App PropriedadesApp;
	public Evento()
	{
		InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_local.ItemsSource = PropriedadesApp.lista_ingresso;
        
        dateInicio.MinimumDate = DateTime.Now;

        dateTermino.MinimumDate = dateInicio.Date.AddDays(1);

    }

    private async void Button_Clicked(object sender, EventArgs e) //avançar
    {
        try
        {
            CustoIngresso h = new CustoIngresso
            {
                LocalSelecionado = (IngressoTipo)pck_local.SelectedItem,
                QntParticipantes = Convert.ToInt32(stp_participantes.Value),
                DataInicio = dateInicio.Date,
                DataTermino = dateTermino.Date,
            };
            

            await Navigation.PushAsync(new CustoEvento()
            {
                BindingContext = h
            }); 

        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void dateInicio_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;
        DateTime data_selecionada_inicio = elemento.Date;

        dateTermino.MinimumDate = data_selecionada_inicio.AddDays(1);
    }
}