namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    App PropriedadesApp;

	public ContratacaoHospedagem()
	{
		InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

        dtcpk_checkin.MinimumDate = DateTime.Now;
        dtcpk_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month +1, DateTime.Now.Day);

        dtcpk_checkout.MinimumDate = dtcpk_checkin.Date.Value.AddDays(1);
        dtcpk_checkout.MaximumDate = dtcpk_checkin.Date.Value.AddMonths(6);

    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());

    {

    }
}

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new HospedagemContratada());
        }
        catch (Exception ex)
        {
            DisplayAlert("Erro", ex.Message, "OK");
        }
    }

    private void dtcpk_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_checkin = (DateTime)elemento.Date;

        dtcpk_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtcpk_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);
    }
}