using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculoSoft.Communs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculoSoft.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        /// <summary>
        /// Endpoint que calcula os juros levando em consideração a taxa nossa api TaxaSoft
        /// </summary>
        /// <param name="valorinicial"></param>
        /// <param name="meses"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<double> CalculaJuros(double valorinicial, double meses)
        {
            //retorna calculo Valor Inicial * (1 + juros)^tempo
            return await SoftRule.RetornaCalculo(valorinicial, meses);
        }
    }
}