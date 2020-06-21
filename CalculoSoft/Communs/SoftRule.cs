using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculoSoft.Communs
{
    public static class SoftRule
    {
        //Esse método irá chamar a api aonde fica a nossa taxa 
        public static async Task<string> RetornaCalculo(double vlrIni, int meses, string url, bool teste = false, double?valor = null)
        {
            double taxa = 0;
            //valida testes passando a taxa como parametro
            if (teste)
            {
                taxa = (double)valor;
            }
            else
            {
                taxa = await SoftRest.Get(url);
            }
            //devolve o caulo truncando para duas casas decimais
            string calculo =  (vlrIni * Math.Pow((1 + taxa),meses)).ToString();
            if (calculo.Contains(','))
            {
                return calculo.Split(',')[0] + "," + calculo.Split(',')[1].Substring(0, 2);
            }
            else
            {
                return calculo;
            }
        }
    }
}
