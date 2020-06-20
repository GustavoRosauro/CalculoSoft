using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CalculoSoft.Communs
{    
    public static class SoftRest
    {
        public static async Task<double> Get(string url)
        {
            using (var client = new HttpClient())
            {   //https:localhost
                //http:docker
                var result =  await client.GetAsync("https://"+url+"/taxajuros");
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
