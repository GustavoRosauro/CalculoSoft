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
                // executando no visual studio http://localhost:64071/taxajuros
                //executando no docker http://192.168.99.100:5001/taxajuros
                var result =  await client.GetAsync("http://localhost:64071/taxajuros");
                if (result.IsSuccessStatusCode)
                {
                    //Executando local 
                    return Convert.ToDouble(result.Content.ReadAsStringAsync().Result.Replace(".",","));
                    // executando no docker 
                    //return Convert.ToDouble(result.Content.ReadAsStringAsync().Result);
                }
                else
                {
                    throw new Exception("Verifique se a URL está igual a do projeto TaxaSoft");
                }
            }
        }
    }
}
