using MauiAppEvento.Models;

namespace MauiAppEvento.View;

public partial class CustoEvento : ContentPage
{
	public CustoEvento()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e) //voltar
    {
        try
        {            
             Navigation.PopAsync();
        }
        catch (Exception ex)
        {
             DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}