using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculoSoft.Communs
{
    public static class SoftRule
    {
        //Esse método irá chamar a api aonde fica a nossa taxa 
        public static async Task<double> RetornaCalculo(double vlrIni, double meses,bool teste = false, double?valor = null)
        {
            double taxa = 0;
            //valida testes passando a taxa como parametro
            if (teste)
            {
                taxa = (double)valor;
            }
            else
            {
                taxa = await SoftRest.Get();
            }
            //devolve o caulo arredondando para duas casas decimais
            return Math.Round(vlrIni * Math.Pow((1 + taxa),meses),2); 
        }
    }
}
