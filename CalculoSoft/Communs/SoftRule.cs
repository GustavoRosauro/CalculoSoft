using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculoSoft.Communs
{
    public static class SoftRule
    {
        //Esse método irá chamar a api aonde fica a nossa taxa 
        public static async Task<double> RetornaCalculo(double vlrIni, double meses, string url, bool teste = false, double?valor = null)
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
            //devolve o caulo arredondando para duas casas decimais
            string calculo =  (vlrIni * Math.Pow((1 + taxa),meses)).ToString("0.00");
            return Convert.ToDouble(calculo);
        }
    }
}
