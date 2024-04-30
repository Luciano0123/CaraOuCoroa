using CaraOuCoroa.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace CaraOuCoroa.ViewModels
{
    internal partial class CoinViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _side;

        [ObservableProperty]
        private string _ladoEscolhido;

        [ObservableProperty]
        private string _resultado;

        public CoinViewModel() {
            JogaCommand = new Command(joga);
        }

        public ICommand JogaCommand{get;}

        public void joga() {
            Coin coin = new Coin();
            Resultado = coin.Joga(LadoEscolhido);
        }
    }
}
