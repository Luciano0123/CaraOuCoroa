using CaraOuCoroa.Models;
using CaraOuCoroa.ViewModels;

namespace CaraOuCoroa.Views;

public partial class CoinVeiw : ContentPage
{
	public CoinVeiw()
	{
		InitializeComponent();
        pickerCoin.SelectedIndex = 0;

		this.BindingContext = new CoinViewModel();
	}
	private void PlayBtn_Clicked(object sender, EventArgs e)
	{
		string sideSelect = pickerCoin.SelectedItem as string;

		Coin coin = new Coin();
		string resultado = coin.Joga(sideSelect);
        CoinTxt.Text = resultado;

    }
}