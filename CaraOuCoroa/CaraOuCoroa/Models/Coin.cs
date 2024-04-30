using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaraOuCoroa.Models
{
    public class Coin
    {
        public string Side { get; set; }

        public string Joga(String ladoEscolhido)
        {
            int ladoSorteado = new Random().Next(2);

            Side = ladoSorteado == 0 ? "Cara" : "Coroa";
            String resultado = Side == ladoEscolhido ? $"Parabens, tu acertastes {ladoEscolhido} " : $"calvo desgramado, tu errou não era {ladoEscolhido}";
            return (resultado);
        }
    }
}
