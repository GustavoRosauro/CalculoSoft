using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CalculoSoft.Communs
{    
    public static class SoftRest
    {
        public static async Task<double> Get()
        {
            using (var client = new HttpClient())
            {
                var result =  await client.GetAsync("http://localhost:64071/taxajuros");
                if (result.IsSuccessStatusCode)
                {
                    return Convert.ToDouble(result.Content.ReadAsStringAsync().Result.Replace(".",","));
                }
                else
                {
                    throw new Exception("Verifique se a URL está igual a do projeto TaxaSoft");
                }
            }
        }
    }
}
