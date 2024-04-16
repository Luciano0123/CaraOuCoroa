namespace CaraOuCoroa
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void PlayBtn_Clicked(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            int coin = aleatorio.Next(2);
            
            if(coin == 0)
            {
                coinIMG.Source = "coroa.jpeg";
            }
            if (coin == 1)
            {
                coinIMG.Source = "cara.jpeg";
            }
            String pick = Convert.ToString(pickerCoin.SelectedItem);

            if(pick == "Cara" && coin == 1)
            {
                CoinTxt.Text = "Correto";
            }
            else if (pick == "Cara" && coin == 0)
            {
                CoinTxt.Text = "Errado";
            }
            else if (pick == "Coroa" && coin == 0)
            {
                CoinTxt.Text = "Certo";
            }
            else if (pick == "Coroa" && coin == 1)
            {
                CoinTxt.Text = "Errado";
            }
            else
            {
                CoinTxt.Text = "Nada selecionado";
            }
        }
    }

}
